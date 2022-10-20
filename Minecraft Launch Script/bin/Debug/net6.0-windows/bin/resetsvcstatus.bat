@echo off
::Minecraft Launch Script "resetsvcstatus.bat" made by SAHIL BHANDARI.
title resetsvcstatus
color 0a
cd bin
regedit /s MinecraftOFF.reg
net start ClipSVC
exit