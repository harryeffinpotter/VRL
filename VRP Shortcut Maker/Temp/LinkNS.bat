
@echo off
setlocal enableExtensions disableDelayedExpansion
set /p exepath=<temp2.txt
set /p exewithoutVD=<temp3.txt
set /p gamedir=<GDir.txt
set /p gamename=<gname.txt
set /p occyns=<nosteamoc.txt

cd %gamedir%
echo "%occyns%">"%gamedir%\%gamename%(Link).bat"
echo "%occyns%">".\b2e\Run\%gamename%(Link).bat"
echo Set oWS = WScript.CreateObject("WScript.Shell") > CreateShortcut.vbs
echo sLinkFile = "%HOMEDRIVE%%HOMEPATH%\Desktop\%gamename%(Link).lnk" >> CreateShortcut.vbs
echo Set oLink = oWS.CreateShortcut(sLinkFile) >> CreateShortcut.vbs
echo oLink.TargetPath = "%gamedir%\%gamename%(Link).bat">> CreateShortcut.vbs
echo oLink.WorkingDirectory = "%gamedir%" >> CreateShortcut.vbs
echo oLink.IconLocation = "%exepath%" >> CreateShortcut.vbs
echo oLink.Save >> CreateShortcut.vbs

cscript CreateShortcut.vbs
del CreateShortcut.vbs

exit
