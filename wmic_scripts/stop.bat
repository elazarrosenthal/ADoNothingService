rem set node="dt-dell4h5vkm1"
set node="msmq2008"
set servicename="ADoNothingService"
wmic /node: %node% service where name=%servicename% call stopservice
