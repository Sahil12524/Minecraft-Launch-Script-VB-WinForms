@echo off
::Minecraft Launch Script "stop.bat" made by SAHIL BHANDARI.
title stop
color 0a
cd bin
tasklist /fi "ImageName eq Minecraft.Windows.exe" /fo csv 2>NUL | find /I "minecraft.windows.exe">NUL
if "%ERRORLEVEL%"=="1" goto FAIL
:STOP ::This is the start of the script.
regedit /s MinecraftOFF.reg
net start ClipSVC
timeout 3 /nobreak
taskkill /F /IM "Minecraft.Windows.exe"
taskkill /F /IM "StartMenuExperienceHost.exe"
goto EXIT
:FAIL ::The blk where the script encounters an error.
color 04
echo ERROR: 
echo 1. The Minecraft was not running, hence not stopped. 
echo 2. Make sure that Minecraft is installed Correctly.
echo 3. Or if the game was closed forcefully by mistakely please press the 'Reset Clip Service' button to avoid windows store problems.
pause
goto EXIT
:EXIT ::Exit blk to terminate the script.
exit