set msipath="\\dt-dell4h5vkm1\netdrop\ADoNothingServiceInstaller.msi"
rem set node="dt-dell4h5vkm1"
set node="msmq2008"
rem wmic /node: %node% product install true,"",%msipath%


rem uneeded fix?
set tmppath="\\msmq2008\inetpub\temp\ADoNothingServiceInstaller.msi"
copy %msipath% %tmppath%
wmic /node: %node% product install true,"",%tmppath%
del %tmppath%

