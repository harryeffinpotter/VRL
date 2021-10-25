@echo off
setlocal enableExtensions disableDelayedExpansion
set /p exepath=<temp2.txt
set /p args=<temp3.txt
set /p gamedir=<gdir.txt
set /p gamename=<gname.txt
set /p filename=<filename.txt
set /p steamargs=<tempSteam.txt

cd %gamedir%
echo "%exepath%" %args%>".\Temp\%gamename%(OtherHMDs).bat"
echo Set oWS = WScript.CreateObject("WScript.Shell") > CreateShortcut.vbs
echo sLinkFile = "%HOMEDRIVE%%HOMEPATH%\Desktop\%gamename%(OtherHMDs).lnk" >> CreateShortcut.vbs
echo sLinkFile = "%HOMEDRIVE%%HOMEPATH%\AppData\Roaming\Microsoft\Windows\Start Menu\%gamename%(OtherHMDs).lnk" >> CreateShortcut.vbs
echo Set oLink = oWS.CreateShortcut(sLinkFile) >> CreateShortcut.vbs
echo oLink.TargetPath = "%gamedir%\%gamename%(OtherHMDs).exe" >> CreateShortcut.vbs
echo oLink.WorkingDirectory = "%gamedir%" >> CreateShortcut.vbs
echo oLink.IconLocation = "%exepath%" >> CreateShortcut.vbs
echo oLink.Save >> CreateShortcut.vbs

cscript CreateShortcut.vbsc
del CreateShortcut.vbs
exit
