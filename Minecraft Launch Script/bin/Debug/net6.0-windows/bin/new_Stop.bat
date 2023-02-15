@echo off
::Minecraft Launch Script "new_Stop.bat" made by SAHIL BHANDARI.
color 0a
title New Stop
set curdir=%~dp0
echo %curdir%
taskkill /F /IM "WinStore.App.exe"
taskkill /F /IM "Minecraft.Windows.exe"
taskkill /F /IM "GameBar.exe"
taskkill /F /IM "GameBarFTServer.exe"
taskkill /F /IM "GameBarPresenceWriter.exe"
taskkill /F /IM "gameinputsvc.exe"
taskkill /F /IM "gamingservices.exe"
taskkill /F /IM "XboxIdp.exe"
taskkill /F /IM "WWAHost.exe"
taskkill /F /IM "RuntimeBroker.exe"
taskkill /F /IM "StoreExperienceHost.exe"
taskkill /F /IM "Cortana.exe"
taskkill /F /IM "SearchHost.exe"
taskkill /F /IM "StartMenuExperienceHost.exe"
takeown /f c:\windows\system32\Windows.ApplicationModel.Store.dll
icacls c:\windows\system32\Windows.ApplicationModel.Store.dll /GRANT ADMINISTRATORS:F
del "C:\Windows\System32\Windows.ApplicationModel.Store.dll"
xcopy /o /x "%curdir%\dlls\Original Dlls Backup\System32\Windows.ApplicationModel.Store.dll" "C:\Windows\System32\" /y
xcopy /o /x "%curdir%\dlls\Original Dlls Backup\SysWOW64\Windows.ApplicationModel.Store.dll" "C:\Windows\SysWOW64\" /y