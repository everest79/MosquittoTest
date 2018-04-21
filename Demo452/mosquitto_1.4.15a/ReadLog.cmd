@SET T=System_Control_ReadLog%Random%
@TITLE=%T%
::订阅或取消订阅日志
::mosquitto_sub -u admin -P admin -i %T% -t $SYS/broker/log/M/#
::订阅一般性日志
::mosquitto_sub -u admin -P admin -i %T% -t $SYS/broker/log/#
mosquitto_sub -u admin -P admin -i %T% -t $SYS/broker/log/N/#