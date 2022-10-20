@echo off
::Minecraft Launch Script "start.bat" made by SAHIL BHANDARI.
title start
color 0a
cd bin
:START ::This is the start of the script.
regedit /s MinecraftON.reg
net stop ClipSVC
start /wait explorer.exe shell:appsFolder\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App
timeout 10 /nobreak
tasklist /fi "ImageName eq Minecraft.Windows.exe" /fo csv 2>NUL | find /I "minecraft.windows.exe">NUL
if "%ERRORLEVEL%"=="1" goto FAIL ::Checks the process Minecraft.Windows.exe is running or not, if the process is not running it will shift the control to FAIL. KEY: 1 = error and 0 = success no error.
::timeout 4
::taskkill /F /IM "RuntimeBroker.exe"
taskkill /F /IM "SearchHost.exe"
goto EXIT
:FAIL ::The blk where the script encounters an error.
color 04
start https://www.microsoft.com/store/productId/9NBLGGH2JHXJ
regedit /s MinecraftOFF.reg
net start ClipSVC
taskkill /F /IM "Minecraft.Windows.exe"
taskkill /F /IM "StartMenuExperienceHost.exe"
cls
echo ERROR: Minecraft is not installed on this computer. please install it first!
pause
goto EXIT
:EXIT ::Exit blk to terminate the script.
exit