
@echo off
setlocal enableExtensions disableDelayedExpansion
set /p foundexedir=<foundexedir.txt
set /p justexenoexe=<justexenoexe.txt
set /p justexe=<justexe.txt
set /p exefullpath=<exefullpath.txt
set /p vdrel=<vdrel.txt
set /p vdfull=<vdfull.txt
set /p Args=<"..\..\SpecialArgs.txt"

echo %justexenoexe%>"..\GameName.txt"
echo %foundexedir%>"..\GameDir.txt"

echo FFARM (FFA Repack Mode)ON!>>..\Log\Log.txt
xcopy "%~dp0\_GAMMON\*" "%foundexedir%" /Y/E/H/C/I/Q
echo %justexenoexe%(VD).bat made containing: %vdrel% %Args%>>..\Log\Log.txt
echo %justexenoexe%(Link).bat made containing: %justexe% %Args%>>..\Log\Log.txt

echo %vdrel% %Args%>"".\Temp\%justexenoexe%(VD).bat""
echo %justexe% %Args%>"".\Temp\%justexenoexe%(Link).bat""
:exit
exit

