
@echo off
setlocal enableExtensions disableDelayedExpansion
set /p exepath=<temp2.txt
set /p exewithoutVD=<temp3.txt
set /p gamedir=<GDir.txt
set /p gamename=<gname.txt
set /p occys=<steamoc.txt

cd %gamedir%
echo "%occys%">".\Temp\%gamename%(Link+Steam).bat"
echo Set oWS = WScript.CreateObject("WScript.Shell") > CreateShortcut.vbs
echo sLinkFile = "%HOMEDRIVE%%HOMEPATH%\Desktop\%gamename%(Link+Steam).lnk" >> CreateShortcut.vbs
echo sLinkFile = "%HOMEDRIVE%%HOMEPATH%\AppData\Roaming\Microsoft\Windows\Start Menu\%gamename%(Link+Steam).lnk" >> CreateShortcut.vbs
echo Set oLink = oWS.CreateShortcut(sLinkFile) >> CreateShortcut.vbs
echo oLink.TargetPath = "%gamedir%\%gamename%(Link+Steam).exe">> CreateShortcut.vbs
echo oLink.WorkingDirectory = "%gamedir%" >> CreateShortcut.vbs
echo oLink.IconLocation = "%exepath%" >> CreateShortcut.vbs
echo oLink.Save >> CreateShortcut.vbs

cscript CreateShortcut.vbs
del CreateShortcut.vbs

exit

