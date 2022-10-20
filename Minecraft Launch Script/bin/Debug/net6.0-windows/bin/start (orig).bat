@echo off
title start
color 0a
cd bin
regedit /s MinecraftON.reg
net stop ClipSVC
explorer.exe shell:appsFolder\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App
timeout 15
taskkill /F /IM "RuntimeBroker.exe"
taskkill /F /IM "SearchHost.exe"
exit