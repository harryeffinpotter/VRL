@echo off
set /p gamedir=<foundexedir.txt
set /p justexenoexe=<justexenoexe.txt
set /p justexe=<justexe.txt
set /p exefullpath=<exefullpath.txt
set /p vdrel=<vdrel.txt
set /p vdfull=<vdfull.txt
set /p GameName=<gname.txt
set /p cdd=<currdir.txt

set cdd=%cdd:"=%
set GameName=%GameName:"=%
set gamedir=%gamedir:"=%
set exefullpath=%exefullpath:"=%
echo cdd = %cdd% > log.txt
echo GameName = %GameName% >> log.txt
echo exefullpath = %exefullpath% >> log.txt
echo gamedir = %gamedir% >> log.txt
echo "%exefullpath%" -VR -Steam %Args%>"Temp\%GameName%(Link).bat"
echo Set oWS = WScript.CreateObject("WScript.Shell") > CreateShortcut.vbs
echo sLinkFile = "%APPDATA%\Microsoft\Windows\Start Menu\Programs\My Launchers\%GameName%(Link).lnk" >> CreateShortcut.vbs
echo Set oLink = oWS.CreateShortcut(sLinkFile) >> CreateShortcut.vbs
echo oLink.TargetPath = "%cdd%\My Launchers\%GameName%(Link).exe" >> CreateShortcut.vbs
echo oLink.WorkingDirectory = "%gamedir%" >> CreateShortcut.vbs
echo oLink.IconLocation = "%exefullpath%" >> CreateShortcut.vbs
echo oLink.Save >> CreateShortcut.vbs

cscript CreateShortcut.vbs >> log.txt
del CreateShortcut.vbs

%dis%
echo Set oWS = WScript.CreateObject("WScript.Shell") > CreateShortcut.vbs
echo sLinkFile = "%HOMEDRIVE%%HOMEPATH%\Desktop\%GameName%(Link).lnk" >> CreateShortcut.vbs
echo Set oLink = oWS.CreateShortcut(sLinkFile) >> CreateShortcut.vbs
echo oLink.TargetPath = "%cdd%\My Launchers\%Gamename%(Link).exe" >> CreateShortcut.vbs
echo oLink.WorkingDirectory = "%gamedir%" >> CreateShortcut.vbs
echo oLink.IconLocation = "%exefullpath%" >> CreateShortcut.vbs
echo oLink.Save >> CreateShortcut.vbs

cscript CreateShortcut.vbs >> log.txt
del CreateShortcut.vbs


:exit
exit
