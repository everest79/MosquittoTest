@SET T=System_Control_ReadLog%Random%
@TITLE=%T%
::���Ļ�ȡ��������־
::mosquitto_sub -u admin -P admin -i %T% -t $SYS/broker/log/M/#
::����һ������־
::mosquitto_sub -u admin -P admin -i %T% -t $SYS/broker/log/#
mosquitto_sub -u admin -P admin -i %T% -t $SYS/broker/log/N/#