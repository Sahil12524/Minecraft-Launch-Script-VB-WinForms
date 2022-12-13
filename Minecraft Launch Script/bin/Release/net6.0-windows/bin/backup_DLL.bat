@echo off
::Minecraft Launch Script "backup_DLL.bat" made by SAHIL BHANDARI.
color 0a
title Backup DLL
set curdir=%~dp0
echo %curdir%
echo:
echo press N if you have already backup your original DLL.
echo: 
echo Note: if you backup your dll again it will replace the stock dll with Modified DLL and it will be fatel.
echo: 
echo Press Y if you have not done any backup before.
echo: 
echo The Backup should be done only once not again and again !
echo: 
pause
timeout 5 /nobreak
echo: 
pushd "C:\Windows\System32\" && (xcopy /o /x Windows.ApplicationModel.Store.dll "%curdir%\dlls\Original Dlls Backup\System32")
echo: 
pushd "C:\Windows\sysWOW64\" && (xcopy /o /x Windows.ApplicationModel.Store.dll "%curdir%\dlls\Original Dlls Backup\sysWOW64")
exit