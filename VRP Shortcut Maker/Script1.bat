@echo off
setlocal enableExtensions disableDelayedExpansion
set /p fullpathVD=<temp.txt
set /p exepath=<temp2.txt
set /p exewithoutVD=<temp3.txt
set /p gamedir=<gdir.txt
set /p gamename=<gname.txt
set /p filename=<filename.txt
set /p steamargs=<tempSteam.txt

cd %gamedir%
echo %fullpathVD% %steamargs% > "%gamedir%\%gamename%_Launcher_VD.bat"
echo Set oWS = WScript.CreateObject("WScript.Shell") > CreateShortcut.vbs
echo sLinkFile = "%HOMEDRIVE%%HOMEPATH%\Desktop\%gamename%(Virtual Desktop).lnk" >> CreateShortcut.vbs
echo Set oLink = oWS.CreateShortcut(sLinkFile) >> CreateShortcut.vbs
echo oLink.TargetPath = "%gamedir%\%gamename%_Launcher_VD.bat" >> CreateShortcut.vbs
echo oLink.WorkingDirectory = "%gamedir%" >> CreateShortcut.vbs
echo oLink.IconLocation = "%exepath%" >> CreateShortcut.vbs
echo oLink.Save >> CreateShortcut.vbs

cscript CreateShortcut.vbs
del CreateShortcut.vbs
exit
