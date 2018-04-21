namespace MosquittoTest.Demo
{
    partial class Mosquitto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ParentTopic = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoteHost = new System.Windows.Forms.TextBox();
            this.ClientPrefix = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RemotePort = new System.Windows.Forms.TextBox();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.PublishTab = new System.Windows.Forms.TabPage();
            this.PublishInfo = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.PublishConnectBtn = new System.Windows.Forms.Button();
            this.PublishClientId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PublishPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PublishUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PublishQosCmb = new System.Windows.Forms.ComboBox();
            this.PublishCleanSessionBox = new System.Windows.Forms.CheckBox();
            this.PublishSubTopic = new System.Windows.Forms.TextBox();
            this.PublishRetainBox = new System.Windows.Forms.CheckBox();
            this.PublishBtn = new System.Windows.Forms.Button();
            this.SubscribeTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SubscribeList = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SubscribeInfo = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SubscribeBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.SubscribeConnectBtn = new System.Windows.Forms.Button();
            this.SubscribeClientId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SubscribePassword = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SubscribeUserName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SubscribeQosCmb = new System.Windows.Forms.ComboBox();
            this.SubscribeCleanSessionBox = new System.Windows.Forms.CheckBox();
            this.SubscribeSubTopic = new System.Windows.Forms.TextBox();
            this.SubscribeRetainBox = new System.Windows.Forms.CheckBox();
            this.LoggingTab = new System.Windows.Forms.TabPage();
            this.LogInfo = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SubscribeLog = new System.Windows.Forms.CheckBox();
            this.ConnectLog = new System.Windows.Forms.CheckBox();
            this.EnableLog = new System.Windows.Forms.CheckBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.PublishTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SubscribeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.LoggingTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.ColumnCount = 16;
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopPanel.Controls.Add(this.label7, 0, 0);
            this.TopPanel.Controls.Add(this.ParentTopic, 10, 0);
            this.TopPanel.Controls.Add(this.Password, 8, 0);
            this.TopPanel.Controls.Add(this.UserName, 6, 0);
            this.TopPanel.Controls.Add(this.label1, 1, 0);
            this.TopPanel.Controls.Add(this.RemoteHost, 2, 0);
            this.TopPanel.Controls.Add(this.ClientPrefix, 13, 0);
            this.TopPanel.Controls.Add(this.SaveBtn, 15, 0);
            this.TopPanel.Controls.Add(this.label8, 14, 0);
            this.TopPanel.Controls.Add(this.label2, 3, 0);
            this.TopPanel.Controls.Add(this.label3, 5, 0);
            this.TopPanel.Controls.Add(this.label4, 7, 0);
            this.TopPanel.Controls.Add(this.label5, 9, 0);
            this.TopPanel.Controls.Add(this.label6, 12, 0);
            this.TopPanel.Controls.Add(this.RemotePort, 4, 0);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.RowCount = 1;
            this.TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopPanel.Size = new System.Drawing.Size(964, 32);
            this.TopPanel.TabIndex = 0;
            // 
            // ParentTopic
            // 
            this.ParentTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParentTopic.Location = new System.Drawing.Point(687, 5);
            this.ParentTopic.MaxLength = 15;
            this.ParentTopic.Name = "ParentTopic";
            this.ParentTopic.Size = new System.Drawing.Size(39, 21);
            this.ParentTopic.TabIndex = 9;
            this.ParentTopic.Text = "S2C";
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.Location = new System.Drawing.Point(541, 5);
            this.Password.MaxLength = 15;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 21);
            this.Password.TabIndex = 7;
            this.Password.Text = "admin";
            // 
            // UserName
            // 
            this.UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserName.Location = new System.Drawing.Point(389, 5);
            this.UserName.MaxLength = 15;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(69, 21);
            this.UserName.TabIndex = 5;
            this.UserName.Text = "admin";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RemoteHost
            // 
            this.RemoteHost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoteHost.Location = new System.Drawing.Point(127, 5);
            this.RemoteHost.MaxLength = 15;
            this.RemoteHost.Name = "RemoteHost";
            this.RemoteHost.Size = new System.Drawing.Size(90, 21);
            this.RemoteHost.TabIndex = 1;
            this.RemoteHost.Text = "127.0.0.1";
            // 
            // ClientPrefix
            // 
            this.ClientPrefix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClientPrefix.Location = new System.Drawing.Point(821, 5);
            this.ClientPrefix.MaxLength = 15;
            this.ClientPrefix.Name = "ClientPrefix";
            this.ClientPrefix.Size = new System.Drawing.Size(27, 21);
            this.ClientPrefix.TabIndex = 11;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveBtn.Location = new System.Drawing.Point(878, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(854, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "}";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "DefaultUser:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "DefaultPwd:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "MainTopic:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(732, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "ClientPrefix:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RemotePort
            // 
            this.RemotePort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemotePort.Location = new System.Drawing.Point(264, 5);
            this.RemotePort.MaxLength = 5;
            this.RemotePort.Name = "RemotePort";
            this.RemotePort.Size = new System.Drawing.Size(36, 21);
            this.RemotePort.TabIndex = 3;
            this.RemotePort.Text = "1883";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.PublishTab);
            this.Tabs.Controls.Add(this.SubscribeTab);
            this.Tabs.Controls.Add(this.LoggingTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 32);
            this.Tabs.Name = "Tabs";
            this.Tabs.Padding = new System.Drawing.Point(10, 10);
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(964, 581);
            this.Tabs.TabIndex = 1;
            // 
            // PublishTab
            // 
            this.PublishTab.BackColor = System.Drawing.SystemColors.Control;
            this.PublishTab.Controls.Add(this.PublishInfo);
            this.PublishTab.Controls.Add(this.tableLayoutPanel1);
            this.PublishTab.Location = new System.Drawing.Point(4, 36);
            this.PublishTab.Name = "PublishTab";
            this.PublishTab.Padding = new System.Windows.Forms.Padding(3);
            this.PublishTab.Size = new System.Drawing.Size(956, 541);
            this.PublishTab.TabIndex = 0;
            this.PublishTab.Text = "Publish";
            // 
            // PublishInfo
            // 
            this.PublishInfo.BackColor = System.Drawing.SystemColors.Control;
            this.PublishInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PublishInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PublishInfo.Location = new System.Drawing.Point(3, 67);
            this.PublishInfo.Name = "PublishInfo";
            this.PublishInfo.Size = new System.Drawing.Size(950, 471);
            this.PublishInfo.TabIndex = 1;
            this.PublishInfo.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PublishConnectBtn, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.PublishClientId, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.PublishPassword, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PublishUserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PublishQosCmb, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.PublishCleanSessionBox, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.PublishSubTopic, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PublishRetainBox, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.PublishBtn, 9, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 12);
            this.label17.TabIndex = 15;
            this.label17.Text = "Publish SubTopic:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PublishConnectBtn
            // 
            this.PublishConnectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PublishConnectBtn.Location = new System.Drawing.Point(789, 4);
            this.PublishConnectBtn.Name = "PublishConnectBtn";
            this.PublishConnectBtn.Size = new System.Drawing.Size(119, 23);
            this.PublishConnectBtn.TabIndex = 13;
            this.PublishConnectBtn.Text = "PublishConnect";
            this.PublishConnectBtn.UseVisualStyleBackColor = true;
            // 
            // PublishClientId
            // 
            this.PublishClientId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PublishClientId.Location = new System.Drawing.Point(563, 5);
            this.PublishClientId.MaxLength = 15;
            this.PublishClientId.Name = "PublishClientId";
            this.PublishClientId.Size = new System.Drawing.Size(79, 21);
            this.PublishClientId.TabIndex = 10;
            this.PublishClientId.Text = "PubClient";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(498, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "ClientId:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(399, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "Qos:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PublishPassword
            // 
            this.PublishPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PublishPassword.Location = new System.Drawing.Point(314, 5);
            this.PublishPassword.MaxLength = 15;
            this.PublishPassword.Name = "PublishPassword";
            this.PublishPassword.Size = new System.Drawing.Size(79, 21);
            this.PublishPassword.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "Publish Password:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PublishUserName
            // 
            this.PublishUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PublishUserName.Location = new System.Drawing.Point(116, 5);
            this.PublishUserName.MaxLength = 15;
            this.PublishUserName.Name = "PublishUserName";
            this.PublishUserName.Size = new System.Drawing.Size(79, 21);
            this.PublishUserName.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Publish UserName:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PublishQosCmb
            // 
            this.PublishQosCmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PublishQosCmb.FormattingEnabled = true;
            this.PublishQosCmb.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.PublishQosCmb.Location = new System.Drawing.Point(434, 6);
            this.PublishQosCmb.Name = "PublishQosCmb";
            this.PublishQosCmb.Size = new System.Drawing.Size(58, 20);
            this.PublishQosCmb.TabIndex = 6;
            this.PublishQosCmb.Text = "1";
            // 
            // PublishCleanSessionBox
            // 
            this.PublishCleanSessionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PublishCleanSessionBox.AutoSize = true;
            this.PublishCleanSessionBox.Location = new System.Drawing.Point(648, 8);
            this.PublishCleanSessionBox.Name = "PublishCleanSessionBox";
            this.PublishCleanSessionBox.Size = new System.Drawing.Size(96, 16);
            this.PublishCleanSessionBox.TabIndex = 7;
            this.PublishCleanSessionBox.Text = "CleanSession";
            this.PublishCleanSessionBox.UseVisualStyleBackColor = true;
            // 
            // PublishSubTopic
            // 
            this.PublishSubTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.PublishSubTopic, 7);
            this.PublishSubTopic.Location = new System.Drawing.Point(116, 37);
            this.PublishSubTopic.MaxLength = 50;
            this.PublishSubTopic.Name = "PublishSubTopic";
            this.PublishSubTopic.Size = new System.Drawing.Size(526, 21);
            this.PublishSubTopic.TabIndex = 14;
            // 
            // PublishRetainBox
            // 
            this.PublishRetainBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PublishRetainBox.AutoSize = true;
            this.PublishRetainBox.Checked = true;
            this.PublishRetainBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PublishRetainBox.Location = new System.Drawing.Point(666, 40);
            this.PublishRetainBox.Name = "PublishRetainBox";
            this.PublishRetainBox.Size = new System.Drawing.Size(60, 16);
            this.PublishRetainBox.TabIndex = 16;
            this.PublishRetainBox.Text = "Retain";
            this.PublishRetainBox.UseVisualStyleBackColor = true;
            // 
            // PublishBtn
            // 
            this.PublishBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PublishBtn.Location = new System.Drawing.Point(789, 36);
            this.PublishBtn.Name = "PublishBtn";
            this.PublishBtn.Size = new System.Drawing.Size(119, 23);
            this.PublishBtn.TabIndex = 17;
            this.PublishBtn.Text = "Publish";
            this.PublishBtn.UseVisualStyleBackColor = true;
            // 
            // SubscribeTab
            // 
            this.SubscribeTab.BackColor = System.Drawing.SystemColors.Control;
            this.SubscribeTab.Controls.Add(this.splitContainer1);
            this.SubscribeTab.Controls.Add(this.tableLayoutPanel2);
            this.SubscribeTab.Location = new System.Drawing.Point(4, 36);
            this.SubscribeTab.Name = "SubscribeTab";
            this.SubscribeTab.Padding = new System.Windows.Forms.Padding(3);
            this.SubscribeTab.Size = new System.Drawing.Size(956, 541);
            this.SubscribeTab.TabIndex = 1;
            this.SubscribeTab.Text = "Subscribe";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 67);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SubscribeList);
            this.splitContainer1.Panel1.Controls.Add(this.label19);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SubscribeInfo);
            this.splitContainer1.Size = new System.Drawing.Size(950, 471);
            this.splitContainer1.SplitterDistance = 87;
            this.splitContainer1.TabIndex = 2;
            // 
            // SubscribeList
            // 
            this.SubscribeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubscribeList.FormattingEnabled = true;
            this.SubscribeList.ItemHeight = 12;
            this.SubscribeList.Location = new System.Drawing.Point(0, 23);
            this.SubscribeList.Name = "SubscribeList";
            this.SubscribeList.Size = new System.Drawing.Size(87, 448);
            this.SubscribeList.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 23);
            this.label19.TabIndex = 1;
            this.label19.Text = "Subscribe List";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubscribeInfo
            // 
            this.SubscribeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubscribeInfo.Location = new System.Drawing.Point(0, 0);
            this.SubscribeInfo.Name = "SubscribeInfo";
            this.SubscribeInfo.Size = new System.Drawing.Size(859, 471);
            this.SubscribeInfo.TabIndex = 0;
            this.SubscribeInfo.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.SubscribeBtn, 9, 1);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.SubscribeConnectBtn, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.SubscribeClientId, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label13, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.SubscribePassword, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label15, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.SubscribeUserName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SubscribeQosCmb, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.SubscribeCleanSessionBox, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.SubscribeSubTopic, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.SubscribeRetainBox, 8, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(950, 64);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // SubscribeBtn
            // 
            this.SubscribeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubscribeBtn.Location = new System.Drawing.Point(801, 36);
            this.SubscribeBtn.Name = "SubscribeBtn";
            this.SubscribeBtn.Size = new System.Drawing.Size(119, 23);
            this.SubscribeBtn.TabIndex = 17;
            this.SubscribeBtn.Text = "Subscribe";
            this.SubscribeBtn.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 12);
            this.label18.TabIndex = 14;
            this.label18.Text = "Subscribe SubTopic:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SubscribeConnectBtn
            // 
            this.SubscribeConnectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubscribeConnectBtn.Location = new System.Drawing.Point(801, 4);
            this.SubscribeConnectBtn.Name = "SubscribeConnectBtn";
            this.SubscribeConnectBtn.Size = new System.Drawing.Size(119, 23);
            this.SubscribeConnectBtn.TabIndex = 13;
            this.SubscribeConnectBtn.Text = "SubscribeConnect";
            this.SubscribeConnectBtn.UseVisualStyleBackColor = true;
            // 
            // SubscribeClientId
            // 
            this.SubscribeClientId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubscribeClientId.Location = new System.Drawing.Point(587, 5);
            this.SubscribeClientId.MaxLength = 15;
            this.SubscribeClientId.Name = "SubscribeClientId";
            this.SubscribeClientId.Size = new System.Drawing.Size(79, 21);
            this.SubscribeClientId.TabIndex = 10;
            this.SubscribeClientId.Text = "SubClient";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(522, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "ClientId:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(423, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 5;
            this.label14.Text = "Qos:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SubscribePassword
            // 
            this.SubscribePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubscribePassword.Location = new System.Drawing.Point(338, 5);
            this.SubscribePassword.MaxLength = 15;
            this.SubscribePassword.Name = "SubscribePassword";
            this.SubscribePassword.Size = new System.Drawing.Size(79, 21);
            this.SubscribePassword.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(213, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "Subscribe Password:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SubscribeUserName
            // 
            this.SubscribeUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubscribeUserName.Location = new System.Drawing.Point(128, 5);
            this.SubscribeUserName.MaxLength = 15;
            this.SubscribeUserName.Name = "SubscribeUserName";
            this.SubscribeUserName.Size = new System.Drawing.Size(79, 21);
            this.SubscribeUserName.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "Subscribe UserName:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SubscribeQosCmb
            // 
            this.SubscribeQosCmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubscribeQosCmb.FormattingEnabled = true;
            this.SubscribeQosCmb.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.SubscribeQosCmb.Location = new System.Drawing.Point(458, 6);
            this.SubscribeQosCmb.Name = "SubscribeQosCmb";
            this.SubscribeQosCmb.Size = new System.Drawing.Size(58, 20);
            this.SubscribeQosCmb.TabIndex = 6;
            this.SubscribeQosCmb.Text = "1";
            // 
            // SubscribeCleanSessionBox
            // 
            this.SubscribeCleanSessionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubscribeCleanSessionBox.AutoSize = true;
            this.SubscribeCleanSessionBox.Location = new System.Drawing.Point(672, 8);
            this.SubscribeCleanSessionBox.Name = "SubscribeCleanSessionBox";
            this.SubscribeCleanSessionBox.Size = new System.Drawing.Size(96, 16);
            this.SubscribeCleanSessionBox.TabIndex = 7;
            this.SubscribeCleanSessionBox.Text = "CleanSession";
            this.SubscribeCleanSessionBox.UseVisualStyleBackColor = true;
            // 
            // SubscribeSubTopic
            // 
            this.SubscribeSubTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.SubscribeSubTopic, 7);
            this.SubscribeSubTopic.Location = new System.Drawing.Point(128, 37);
            this.SubscribeSubTopic.MaxLength = 50;
            this.SubscribeSubTopic.Name = "SubscribeSubTopic";
            this.SubscribeSubTopic.Size = new System.Drawing.Size(537, 21);
            this.SubscribeSubTopic.TabIndex = 15;
            // 
            // SubscribeRetainBox
            // 
            this.SubscribeRetainBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubscribeRetainBox.AutoSize = true;
            this.SubscribeRetainBox.Enabled = false;
            this.SubscribeRetainBox.Location = new System.Drawing.Point(690, 40);
            this.SubscribeRetainBox.Name = "SubscribeRetainBox";
            this.SubscribeRetainBox.Size = new System.Drawing.Size(60, 16);
            this.SubscribeRetainBox.TabIndex = 16;
            this.SubscribeRetainBox.Text = "Retain";
            this.SubscribeRetainBox.UseVisualStyleBackColor = true;
            // 
            // LoggingTab
            // 
            this.LoggingTab.BackColor = System.Drawing.SystemColors.Control;
            this.LoggingTab.Controls.Add(this.LogInfo);
            this.LoggingTab.Controls.Add(this.tableLayoutPanel3);
            this.LoggingTab.Location = new System.Drawing.Point(4, 36);
            this.LoggingTab.Name = "LoggingTab";
            this.LoggingTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoggingTab.Size = new System.Drawing.Size(956, 541);
            this.LoggingTab.TabIndex = 2;
            this.LoggingTab.Text = "Logging";
            // 
            // LogInfo
            // 
            this.LogInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogInfo.Location = new System.Drawing.Point(3, 35);
            this.LogInfo.Name = "LogInfo";
            this.LogInfo.Size = new System.Drawing.Size(950, 503);
            this.LogInfo.TabIndex = 1;
            this.LogInfo.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 9;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.Controls.Add(this.SubscribeLog, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.ConnectLog, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.EnableLog, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(950, 32);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // SubscribeLog
            // 
            this.SubscribeLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubscribeLog.AutoSize = true;
            this.SubscribeLog.Location = new System.Drawing.Point(223, 8);
            this.SubscribeLog.Name = "SubscribeLog";
            this.SubscribeLog.Size = new System.Drawing.Size(78, 16);
            this.SubscribeLog.TabIndex = 2;
            this.SubscribeLog.Text = "Subscribe";
            this.SubscribeLog.UseVisualStyleBackColor = true;
            // 
            // ConnectLog
            // 
            this.ConnectLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConnectLog.AutoSize = true;
            this.ConnectLog.Location = new System.Drawing.Point(124, 8);
            this.ConnectLog.Name = "ConnectLog";
            this.ConnectLog.Size = new System.Drawing.Size(66, 16);
            this.ConnectLog.TabIndex = 1;
            this.ConnectLog.Text = "Connect";
            this.ConnectLog.UseVisualStyleBackColor = true;
            // 
            // EnableLog
            // 
            this.EnableLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnableLog.AutoSize = true;
            this.EnableLog.Location = new System.Drawing.Point(19, 8);
            this.EnableLog.Name = "EnableLog";
            this.EnableLog.Size = new System.Drawing.Size(66, 16);
            this.EnableLog.TabIndex = 0;
            this.EnableLog.Text = "Logging";
            this.EnableLog.UseVisualStyleBackColor = true;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.Stop);
            this.BottomPanel.Controls.Add(this.Start);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 613);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(964, 48);
            this.BottomPanel.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = " Configure {";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(342, 13);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(163, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start Mosquitto";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(541, 13);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // Mosquitto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 661);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(980, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(980, 700);
            this.Name = "Mosquitto";
            this.Text = "Mosquitto";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.PublishTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.SubscribeTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.LoggingTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TopPanel;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage PublishTab;
        private System.Windows.Forms.TabPage SubscribeTab;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RemotePort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RemoteHost;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox ParentTopic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ClientPrefix;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TabPage LoggingTab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PublishPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PublishUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox PublishQosCmb;
        private System.Windows.Forms.CheckBox PublishCleanSessionBox;
        private System.Windows.Forms.TextBox PublishClientId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button PublishConnectBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button SubscribeConnectBtn;
        private System.Windows.Forms.TextBox SubscribeClientId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SubscribePassword;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox SubscribeUserName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox SubscribeQosCmb;
        private System.Windows.Forms.CheckBox SubscribeCleanSessionBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox PublishSubTopic;
        private System.Windows.Forms.CheckBox PublishRetainBox;
        private System.Windows.Forms.Button PublishBtn;
        private System.Windows.Forms.RichTextBox PublishInfo;
        private System.Windows.Forms.Button SubscribeBtn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox SubscribeSubTopic;
        private System.Windows.Forms.CheckBox SubscribeRetainBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox LogInfo;
        private System.Windows.Forms.ListBox SubscribeList;
        private System.Windows.Forms.RichTextBox SubscribeInfo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox SubscribeLog;
        private System.Windows.Forms.CheckBox ConnectLog;
        private System.Windows.Forms.CheckBox EnableLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
    }
}