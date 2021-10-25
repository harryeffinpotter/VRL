@echo off
setlocal enableExtensions disableDelayedExpansion
set /p gamename=<gname.txt
set /p exepath=<temp2.txt
set /p gamedir=<GDir.txt
SET /P name=<filename.txt

cd %gamedir%
mkdir B2E
cd B2E
echo "%exepath%" -Steam -VR> "name.bat"