set uninstallname="ADoNothingServiceInstaller"
rem set node="dt-dell4h5vkm1"
set node="msmq2008"
wmic /node: %node% product where name=%uninstallname% call uninstall
