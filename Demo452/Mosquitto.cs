#region Document description
/*
 * 唯一标识 ：56bc5ea6-75c7-410b-a4d7-06209a891777
 * 创建环境 ：DESKTOP-ROHSP5C(CLR:4.0.30319.42000)
 * 文件名称 ：Mosquitto(MQTT)
 * 原始作者 ：Administrator(everest79@qq.com)
 * 创建时间 ：2018/4/19 11:14:00
 */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;

namespace MosquittoTest.Demo
{
    public partial class Mosquitto : Form
    {
        private Process mqttProcess = null;
        private MqttClient syslogClient = null;
        private MqttClient publishClient = null;
        private MqttClient subscribeClient = null;
        private const string Connect_Topic = "$SYS/broker/log/N/#";
        private const string Subscribe_Topic = "$SYS/broker/log/M/#";
        


        #region Configuration
        private int Port => int.TryParse(RemotePort.Text, out int port) ? port : 1883;
        private string Host => string.IsNullOrWhiteSpace(RemoteHost.Text) ? "127.0.0.1" : RemoteHost.Text;
        private string MainTopic => string.IsNullOrWhiteSpace(ParentTopic.Text) ? "S2C" : ParentTopic.Text;
        private string DefaultUserName => string.IsNullOrWhiteSpace(UserName.Text) ? "admin" : UserName.Text;
        private string DefaultPassword => string.IsNullOrWhiteSpace(Password.Text) ? "admin" : Password.Text;
        private string ClientIdPrefix => string.IsNullOrWhiteSpace(ClientPrefix.Text) ? string.Empty : ClientPrefix.Text;
        #endregion

        #region Publish
        private string PublishAllClientId => ClientIdPrefix + (string.IsNullOrWhiteSpace(PublishClientId.Text) ? Environment.MachineName : PublishClientId.Text);
        private string PublishTopic => MainTopic + (string.IsNullOrWhiteSpace(PublishSubTopic.Text) ? string.Empty : "/" + PublishSubTopic.Text);
        private string PublishUser => string.IsNullOrWhiteSpace(PublishUserName.Text) ? DefaultUserName : PublishUserName.Text;
        private string PublishPwd => string.IsNullOrWhiteSpace(PublishPassword.Text) ? DefaultPassword : PublishPassword.Text;
        private byte PublishQos => (byte)(int.TryParse(PublishQosCmb.Text, out int port) ? port : 1);
        private bool PublishCleanSession => PublishCleanSessionBox.Checked;
        private bool PublishRetain => PublishRetainBox.Checked;
        #endregion

        #region Subscribe
        private string SubscribeAllClientId => ClientIdPrefix + (string.IsNullOrWhiteSpace(SubscribeClientId.Text) ? Environment.MachineName : SubscribeClientId.Text);
        private string SubscribeTopic => MainTopic + (string.IsNullOrWhiteSpace(SubscribeSubTopic.Text) ? string.Empty : "/" + SubscribeSubTopic.Text);
        private string SubscribeUser => string.IsNullOrWhiteSpace(SubscribeUserName.Text) ? DefaultUserName : SubscribeUserName.Text;
        private string SubscribePwd => string.IsNullOrWhiteSpace(SubscribePassword.Text) ? DefaultPassword : SubscribePassword.Text;
        private byte SubscribeQos => (byte)(int.TryParse(SubscribeQosCmb.Text, out int port) ? port : 1);
        private bool SubscribeCleanSession => SubscribeCleanSessionBox.Checked;
        //private bool SubscribeRetain => SubscribeRetainBox.Checked;
        #endregion

        public Mosquitto()
        {
            InitializeComponent();
            Load += (sender, args) => {
                // 存盘控件列表
                List<Control> formControls = Controls.GetControls();
                // 异步操作信息临时存储，闭包让各个方法在使用
                Dictionary<ushort, string> messageQueue = new Dictionary<ushort, string>();
                

                // 保存设置
                SaveBtn.Click += (s, e) => {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    formControls.ForEach(ctl => {
                        string key = ctl.Name;
                        if (config.AppSettings.Settings.AllKeys.Contains(key))
                        {
                            config.AppSettings.Settings[key].Value = ctl.GetValue();
                        }
                        else
                        {
                            config.AppSettings.Settings.Add(key, ctl.GetValue());
                        }
                    });
                    config.Save();
                };
                // 发布操作
                PublishBtn.Click += (s, e) => {
                    PublishBtn.Enabled = false;
                    if (publishClient != null)
                    {
                        string message = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        try
                        {
                            var token = publishClient.Publish(PublishTopic, message.GetBytes(), PublishQos, PublishRetain);
                            PublishInfo.AppendInfo($"开始向[\"{PublishTopic}\"]发送编号为{token}的消息[\"{message}\"]，{{Qos:{PublishQos}, Retain:{PublishRetain}}}");
                        }
                        catch (Exception ex)
                        {
                            PublishInfo.AppendError($"发布消息时产生错误：{ ex.Message}{Environment.NewLine}{ex.StackTrace}");
                        }
                    }
                    else
                    {
                        PublishInfo.AppendError($"发布客户端还未建立连接");
                    }
                    PublishBtn.Enabled = true;
                };
                // 订阅操作
                SubscribeBtn.Click += (s, e) => {
                    SubscribeBtn.Enabled = false;
                    if (subscribeClient != null)
                    {
                        try
                        {
                            var token = subscribeClient.Subscribe(new string[] { SubscribeTopic }, new byte[] { SubscribeQos });
                            SubscribeInfo.AppendWarn($"开始订阅[主题:\"{SubscribeTopic}\", 编号:{token}]的消息，{{Qos:{SubscribeQos}}}");
                            messageQueue.AddOrUpdate(token, SubscribeTopic);
                        }
                        catch (Exception ex)
                        {
                            SubscribeInfo.AppendError($"订阅[主题:\"{SubscribeTopic}\"]时产生错误：{ ex.Message}{Environment.NewLine}{ex.StackTrace}");
                        }
                    }
                    else
                    {
                        SubscribeInfo.AppendError($"订阅客户端还未建立连接");
                    }
                    SubscribeBtn.Enabled = true;
                };
                // 取消订阅
                SubscribeList.DoubleClick += (s, e) => {
                    if (subscribeClient == null)
                    {
                        SubscribeInfo.AppendError($"订阅客户端还未建立连接，不能取消订阅");
                    }
                    else
                    {
                        string topic = SubscribeList.SelectedItem as string;
                        if (string.IsNullOrWhiteSpace(topic)) return;
                        try
                        {
                            var token = subscribeClient.Unsubscribe(new string[] { topic });
                            messageQueue.AddOrUpdate(token, topic);
                            SubscribeInfo.AppendWarn($"开始取消订阅[主题:\"{SubscribeTopic}\"],编号:{token}");
                        }
                        catch (Exception ex)
                        {
                            SubscribeInfo.AppendError($"取消订阅[主题:\"{topic}\"]时产生错误：{ ex.Message}{Environment.NewLine}{ex.StackTrace}");
                        }
                        finally
                        {
                            

                        }
                    }
                };
                // 发布连接
                PublishConnectBtn.Click += (s, e) => {
                    PublishConnectBtn.Enabled = false;
                    if (publishClient == null)
                    {
                        MqttClient _client = null;
                        string url = $"tcp://{Host}:{Port} {{User:{PublishUser}, ClientID:{PublishAllClientId}, Qos:{PublishQos}, CleanSession:{ PublishCleanSession}, NoSSL, NoWill}}";
                        try
                        {
                            _client = new MqttClient(Host, Port, false, null, null, MqttSslProtocols.None);
                            byte connack = _client.Connect(PublishAllClientId, PublishUser, PublishPwd, false, PublishQos, false, null, null, PublishCleanSession, 60);
                            _client.ConnectionClosed += (a, b) =>
                            {
                                BeginInvoke(new Action(() => {
                                    PublishInfo.AppendWarn($"已断开与{url}的连接");
                                }));
                            };
                            _client.MqttMsgPublished += (a, b) =>
                            {
                                BeginInvoke(new Action(()=> {
                                    PublishInfo.AppendInfo($"编号为{b.MessageId}的消息发送{(b.IsPublished ? "成功" : "失败")}");
                                }));
                                
                            };
                            PublishInfo.AppendWarn($"已成功与{url}建立连接 CONNACK:{connack.GetBinary()}");
                            publishClient = _client;
                        }
                        catch (Exception ex)
                        {
                            PublishInfo.AppendError($"建立连接时产生错误：{ ex.Message}{Environment.NewLine}{ex.StackTrace}");
                        }
                        finally
                        {
                            _client = null;
                            if (publishClient != null)
                            {
                                PublishConnectBtn.Text = "Disconnect";
                            }
                          }
                    }
                    else
                    {
                        try
                        {
                            publishClient?.Disconnect();
                        }
                        catch(Exception ex)
                        {
                            PublishInfo.AppendError($"断开连接时产生错误：{ ex.Message}{Environment.NewLine}{ex.StackTrace}");
                        }
                        finally
                        {
                            PublishConnectBtn.Text = "PublishConnect";
                            publishClient = null;
                        }
                    }
                    PublishConnectBtn.Enabled = true;
                };
                // 订阅连接
                SubscribeConnectBtn.Click += (s, e) => {
                    SubscribeConnectBtn.Enabled = false;
                    if (subscribeClient == null)
                    {
                        MqttClient _client = null;
                        string url = $"tcp://{Host}:{Port} {{User:{SubscribeUser}, ClientID:{SubscribeAllClientId}, Qos:{SubscribeQos}, CleanSession:{ SubscribeCleanSession}, NoSSL, NoWill}}";
                        try
                        {
                            _client = new MqttClient(Host, Port, false, null, null, MqttSslProtocols.None);
                            // 连接断开
                            _client.ConnectionClosed += (a, b) =>
                            {
                                BeginInvoke(new Action(() => {
                                    SubscribeInfo.AppendWarn($"已断开与{url}的连接");
                                }));
                            };
                            // 接收到消息
                            _client.MqttMsgPublishReceived += (a, b) => {
                                BeginInvoke(new Action(() => {
                                    SubscribeInfo.AppendInfo($"接收到来自[主题\"{b.Topic}\"]的消息[\"{b.Message.GetString()}\"]{{DupFlag:{b.DupFlag}, QosLevel:{b.QosLevel.GetBinary()}, Retain:{b.Retain}}}");
                                }));
                            };
                            // 订阅完成
                            _client.MqttMsgSubscribed += (a, b) => {
                                BeginInvoke(new Action(() => {
                                    string topic = messageQueue.GetDefaultValue(b.MessageId);
                                    if (string.IsNullOrWhiteSpace(topic)) return;
                                    SubscribeInfo.AppendWarn($"订阅主题{topic}成功，编号:{b.MessageId} Qoss:{b.GrantedQoSLevels.GetBinarys()}");
                                    SubscribeList.Items.AddOrUpdate(topic);
                                }));
                            };
                            // 取消订阅完成
                            _client.MqttMsgUnsubscribed += (a, b) => {
                                BeginInvoke(new Action(() => {
                                    string topic = messageQueue.GetDefaultValue(b.MessageId);
                                    if (string.IsNullOrWhiteSpace(topic)) return;
                                    SubscribeInfo.AppendWarn($"取消订阅主题{topic}成功，编号:{b.MessageId}");
                                    SubscribeList.Items.Remove(topic);
                                }));
                            };
                            byte connack = _client.Connect(SubscribeAllClientId, SubscribeUser, SubscribePwd, false, SubscribeQos, false, null, null, SubscribeCleanSession, 60);
                            SubscribeInfo.AppendWarn($"已成功与{url}建立连接 CONNACK:{connack.GetBinary()}");
                            subscribeClient = _client;
                        }
                        catch (Exception ex)
                        {
                            SubscribeInfo.AppendError($"建立连接时产生错误：{ ex.Message}{Environment.NewLine}{ex.StackTrace}");
                        }
                        finally
                        {
                            _client = null;
                            if (subscribeClient != null)
                            {
                                SubscribeConnectBtn.Text = "Disconnect";
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            subscribeClient?.Disconnect();
                        }
                        catch (Exception ex)
                        {
                            SubscribeInfo.AppendError($"断开连接时产生错误：{ ex.Message}{Environment.NewLine}{ex.StackTrace}");
                        }
                        finally
                        {
                            SubscribeConnectBtn.Text = "SubscribeConnect";
                            subscribeClient = null;
                        }
                    }
                    SubscribeConnectBtn.Enabled = true;
                };
                // 加载存档
                formControls.ForEach(ctl => ctl.LoadValue());
                // 开启日志
                EnableLog.CheckedChanged += (s, e) => {
                    EnableLog.Enabled = false;
                    if (EnableLog.Checked)
                    {
                        if (syslogClient == null)
                        {
                            MqttClient _client = null;
                            string syslogid = $"{ClientIdPrefix}__Syslog__";
                            string url = $"tcp://{Host}:{Port} {{User:{DefaultUserName}, ClientID:{syslogid}, Qos:0, CleanSession:true, NoSSL, NoWill}}";
                            try
                            {
                                _client = new MqttClient(Host, Port, false, null, null, MqttSslProtocols.None);
                                // 连接断开
                                _client.ConnectionClosed += (a, b) =>
                                {
                                    BeginInvoke(new Action(() =>
                                    {
                                        LogInfo.AppendWarn($"已断开与{url}的连接");
                                    }));
                                };
                                // 接收到消息
                                _client.MqttMsgPublishReceived += (a, b) => {
                                    BeginInvoke(new Action(() => {
                                        LogInfo.AppendInfo($"接收到来自[主题\"{b.Topic}\"]的消息[\"{b.Message.GetString()}\"]{{DupFlag:{b.DupFlag}, QosLevel:{b.QosLevel.GetBinary()}, Retain:{b.Retain}}}");
                                    }));
                                };
                                byte connack = _client.Connect(syslogid, DefaultUserName, DefaultPassword, false, 0x00, false, null, null, true, 60);
                                LogInfo.AppendWarn($"已成功与{url}建立连接 CONNACK:{connack.GetBinary()}");
                                syslogClient = _client;
                            }
                            catch (Exception ex)
                            {
                                LogInfo.AppendError($"建立连接时产生错误：{ ex.Message}{Environment.NewLine}{ex.StackTrace}");
                            }
                            finally
                            {
                                _client = null;
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            syslogClient?.Disconnect();
                        }
                        catch (Exception ex)
                        {
                            LogInfo.AppendError($"断开连接时产生错误：{ ex.Message}{Environment.NewLine}{ex.StackTrace}");
                        }
                        finally
                        {
                            syslogClient = null;
                        }
                    }
                    EnableLog.Enabled = true;
                };
                // 连接日志
                ConnectLog.CheckedChanged += (s, e) => {
                    ConnectLog.Enabled = false;
                    if (ConnectLog.Checked)
                    {
                        if (syslogClient != null)
                        {
                            try
                            {
                                var token = syslogClient.Subscribe(new string[] { Connect_Topic }, new byte[] { 0x00 });
                                LogInfo.AppendWarn($"开始订阅[主题:\"{Connect_Topic}\", 编号:{token}]的消息，{{Qos:{0x00}}}");
                            }
                            catch (Exception ex)
                            {
                                LogInfo.AppendError($"订阅[主题:\"{Connect_Topic}\"]时产生错误：{ ex.Message}{Environment.NewLine}{ex.StackTrace}");
                            }
                        }
                        else
                        {
                            LogInfo.AppendError($"订阅客户端还未建立连接");
                        }
                    }
                    else
                    {
                        try
                        {
                            var token = syslogClient.Unsubscribe(new string[] { Connect_Topic });
                            LogInfo.AppendWarn($"开始取消订阅[主题:\"{Connect_Topic}\"],编号:{token}");
                        }
                        catch (Exception ex)
                        {
                            LogInfo.AppendError($"取消订阅[主题:\"{Connect_Topic}\"]时产生错误：{ ex.Message}{Environment.NewLine}{ex.StackTrace}");
                        }
                        finally
                        {


                        }
                    }
                    ConnectLog.Enabled = true;
                };
                // 订阅日志
                SubscribeLog.CheckedChanged += (s, e) => {
                    SubscribeLog.Enabled = false;
                    if (SubscribeLog.Checked)
                    {
                        if (syslogClient != null)
                        {
                            try
                            {
                                var token = syslogClient.Subscribe(new string[] { Subscribe_Topic }, new byte[] { 0x00 });
                                LogInfo.AppendWarn($"开始订阅[主题:\"{Subscribe_Topic}\", 编号:{token}]的消息，{{Qos:{0x00}}}");
                            }
                            catch (Exception ex)
                            {
                                LogInfo.AppendError($"订阅[主题:\"{Subscribe_Topic}\"]时产生错误：{ ex.Message}{Environment.NewLine}{ex.StackTrace}");
                            }
                        }
                        else
                        {
                            LogInfo.AppendError($"订阅客户端还未建立连接");
                        }
                    }
                    else
                    {
                        try
                        {
                            var token = syslogClient.Unsubscribe(new string[] { Subscribe_Topic });
                            LogInfo.AppendWarn($"开始取消订阅[主题:\"{Subscribe_Topic}\"],编号:{token}");
                        }
                        catch (Exception ex)
                        {
                            LogInfo.AppendError($"取消订阅[主题:\"{Subscribe_Topic}\"]时产生错误：{ ex.Message}{Environment.NewLine}{ex.StackTrace}");
                        }
                        finally
                        {


                        }
                    }
                    SubscribeLog.Enabled = true;
                };

                Start.Click += (s, e) => {
                    try
                    {
                        Start.Enabled = false;
                        ProcessStartInfo info = new ProcessStartInfo("mosquitto.exe", "-c mosquitto.conf");
                        info.WindowStyle = ProcessWindowStyle.Hidden;
                        info.WorkingDirectory = "mosquitto_1.4.15a";
                        mqttProcess = Process.Start(info);
                        mqttProcess.Exited += (a, b) =>
                        {
                            BeginInvoke(new Action(() => { }));
                        };
                        Stop.Enabled = true;
                    }
                    catch {
                        mqttProcess?.Kill();
                        Start.Enabled = true;
                    }
                    
                };
                Stop.Click += (s, e) => {
                    Stop.Enabled = false;
                    try
                    {
                        mqttProcess?.Kill();
                    }
                    catch { }
                    finally
                    {
                        mqttProcess?.Dispose();
                        mqttProcess = null;
                    }
                    Start.Enabled = true;
                };



                // 关闭后退出进程
                FormClosed += (s, e) => {
                    try
                    {
                        mqttProcess?.Kill();
                    }
                    catch { }
                    Environment.Exit(0);
                };
                

            };
        }
    }

    public static class Extensions
    {
        private static string Time => DateTime.Now.ToString("HH:mm:ss.fff");

        #region 字节转换
        /// <summary>
        /// 字节转二进制字符串
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string GetBinary(this byte b)
        {
            return Convert.ToString(b, 2).PadLeft(8, '0');
        }
        /// <summary>
        /// 字符串转二进制字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetBinarys(this string str)
        {
            return str.GetBytes().GetBinarys();
        }
        /// <summary>
        /// 字节数组转二进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string GetBinarys(this byte[] bytes)
        {
            StringBuilder builder = new StringBuilder();
            bytes.ToList().ForEach(b => builder.Append($"{b.GetBinary()} "));
            return builder.ToString();
        }
        /// <summary>
        /// 字符串转字节数组
        /// </summary>
        /// <param name="text"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static byte[] GetBytes(this string text, Encoding encoding = null)
        {
            if (encoding == null) encoding = Encoding.UTF8;
            return encoding.GetBytes(text);
        }
        /// <summary>
        /// 字节数组转字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string GetString(this byte[] bytes, Encoding encoding = null)
        {
            if (encoding == null) encoding = Encoding.UTF8;
            return encoding.GetString(bytes);
        }
        #endregion

        #region Configuration
        /// <summary>
        /// 加载控件保存的值
        /// </summary>
        /// <param name="ctl"></param>
        public static void LoadValue(this Control ctl)
        {
            string key = ctl?.Name;
            if (ctl == null || string.IsNullOrWhiteSpace(key)) return;
            string value = ConfigurationManager.AppSettings[key];
            if (string.IsNullOrWhiteSpace(value)) return;
            if (ctl is TextBox || ctl is ComboBox)
            {
                ctl.Text = value;
            }
            else if (ctl is CheckBox checkBox && bool.TryParse(value, out bool boolValue))
            {
                checkBox.Checked = boolValue;
            }
        }
        /// <summary>
        /// 获取控件当前的值
        /// </summary>
        /// <param name="ctl"></param>
        /// <returns></returns>
        public static string GetValue(this Control ctl)
        {
            string result = string.Empty;
            if (ctl is TextBox || ctl is ComboBox)
                result = ctl.Text;
            else if (ctl is CheckBox checkbox)
                result = checkbox.Checked.ToString();
            return result;
        }
        /// <summary>
        /// 可递归获取指定条件的控件集合，默认获取TextBox ComboBox ChechBox
        /// </summary>
        /// <param name="controls">要遍历的集合</param>
        /// <param name="func">条件</param>
        /// <param name="recursive">是否递归</param>
        /// <returns></returns>
        public static List<Control> GetControls(this Control.ControlCollection controls, Func<Control,bool> func = null, bool recursive = true)
        {
            if(func == null)
                func = c => c is TextBox || c is ComboBox || c is CheckBox;
            List<Control> ctls = new List<Control>();
            foreach (Control ctl in controls)
            {
                if (func(ctl))
                {
                    ctls.Add(ctl);
                }
                else if (recursive && ctl.Controls.Count > 0)
                {
                    IList<Control> list = GetControls(ctl.Controls, func, recursive);
                    if (list.Count > 0)
                    {
                        ctls.AddRange(list);
                    }
                }
            }
            return ctls;
        }
        #endregion

        #region Collection
        /// <summary>
        /// 添加或更新更表
        /// </summary>
        /// <param name="oc"></param>
        /// <param name="item"></param>
        public static void AddOrUpdate(this ListBox.ObjectCollection oc, object item)
        {
            if (!oc.Contains(item)) oc.Add(item);
        }
        /// <summary>
        /// 添加或更新值
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dict"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void AddOrUpdate<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (dict.Keys.Contains(key))
            {
                dict[key] = value;
            }
            else
            {
                dict.Add(key, value);
            }
        }
        /// <summary>
        /// 获取值，不存在返回类型默认值
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dict"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static TValue GetDefaultValue<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key)
        {
            TValue result = default(TValue);
            if (dict.Keys.Contains(key))
            {
                result = dict[key];
            }
            return result;
        }
        #endregion

        #region RichTextBox
        /// <summary>
        /// 追加指定颜色的一行文本
        /// </summary>
        /// <param name="box"></param>
        /// <param name="text"></param>
        /// <param name="color"></param>
        public static void AppendLine(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = Color.SlateGray;
            box.AppendText(Time);
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText($" {text}{Environment.NewLine}");
            box.SelectionColor = box.ForeColor;
        }
        /// <summary>
        /// 追加红色错误文本行
        /// </summary>
        /// <param name="box"></param>
        /// <param name="text"></param>
        public static void AppendError(this RichTextBox box, string text)
        {
            box.AppendLine(text, Color.Red);
        }
        /// <summary>
        /// 追加蓝色提醒文本行
        /// </summary>
        /// <param name="box"></param>
        /// <param name="text"></param>
        public static void AppendWarn(this RichTextBox box, string text)
        {
            box.AppendLine(text, Color.Blue);
        }
        /// <summary>
        /// 追加默认颜色文本行
        /// </summary>
        /// <param name="box"></param>
        /// <param name="text"></param>
        public static void AppendInfo(this RichTextBox box, string text)
        {
            box.AppendLine(text, box.ForeColor);
        }
        #endregion
    }
}
