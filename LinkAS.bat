@echo off
setlocal enableExtensions disableDelayedExpansion
set /p foundexedir=<foundexedir.txt
set /p justexenoexe=<justexenoexe.txt
set /p justexe=<justexe.txt
set /p exefullpath=<exefullpath.txt
set /p vdrel=<vdrel.txt
set /p vdfull=<vdfull.txt
set /p Args=<"..\..\SpecialArgs.txt"
set /p GameName=<gname.txt
echo %justexenoexe%>"..\GameName.txt"
echo %foundexedir%>"..\GameDir.txt"

echo FFARM (FFA Repack Mode)ON!>>..\Log\Log.txt
echo %justexenoexe%(Link).bat made containing: %justexe% -VR -Steam %Args%>>..\Log\Log.txt

echo %justexe% -VR -Steam %Args%>"".\Temp\"%GameName%(Link).bat"""
:exit
exit