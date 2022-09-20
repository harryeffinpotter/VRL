@echo off
set /p foundexedir=<foundexedir.txt
set /p justexenoexe=<justexenoexe.txt
set /p justexe=<justexe.txt
set /p exefullpath=<exefullpath.txt
set /p vdrel=<vdrel.txt
set /p vdfull=<vdfull.txt
set /p Args=<"..\..\SpecialArgs.txt"
set /p GameName=<gname.txt
set /p dis=<dis.txt
echo %justexenoexe%>"..\GameName.txt"
echo %foundexedir%>"..\GameDir.txt"
echo %vdrel% -VR -Steam %Args%>Temp\%GameName%(VD).bat
:exit
exit
