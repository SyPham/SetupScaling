@echo off
color 2
title Create services: SHW_AutoRestartService, SHW_WeighingScale30kg, SHW_WeighingScale3kg, SHW_SignalrServer, Install ZTek USB driver

echo "Install ZTek USB driver"
C:\service\CDM21228_Setup\CDM21228_Setup.exe

echo "Create SHW_AutoRestartService"
sc create SHW_AutoRestartService BinPath=C:\service\autorestartservice\AutoService.exe start=auto
sc description SHW_AutoRestartService "This service is used for SHW Digital Mixing Room System. Please do not stop it if you don't know . For more info please contact : SHC>FHO>Peter.Tran mobile : 0974111464 , email : peter.tran@shc.ssbshoes.com"
sc start SHW_AutoRestartService

echo "Create SHW_WeighingScale30kg"
sc create SHW_WeighingScale30kg BinPath=C:\service\weighingScale30kg\ScalingMachineService.exe start=auto
sc description SHW_WeighingScale30kg "This service is used for SHW Digital Mixing Room System. Please do not stop it if you don't know . For more info please contact : SHC>FHO>Peter.Tran mobile : 0974111464 , email : peter.tran@shc.ssbshoes.com"
sc start SHW_WeighingScale30kg

echo "Create SHW_WeighingScale3kg"
sc create SHW_WeighingScale3kg BinPath=C:\service\weighingScale3kg\ScalingMachineService.exe start=auto
sc description SHW_WeighingScale3kg "This service is used for SHW Digital Mixing Room System. Please do not stop it if you don't know . For more info please contact : SHC>FHO>Peter.Tran mobile : 0974111464 , email : peter.tran@shc.ssbshoes.com"
sc start SHW_WeighingScale3kg

echo "Create SHW_SignalrServer"
sc create SHW_SignalrServer BinPath=C:\service\signalrServer\SignalrServer.exe start=auto
sc description SHW_SignalrServer "This service is used for SHW Digital Mixing Room System. Please do not stop it if you don't know . For more info please contact : SHC>FHO>Peter.Tran mobile : 0974111464 , email : peter.tran@shc.ssbshoes.com"
sc start SHW_SignalrServer

sc stop SHW_WeighingScale30kg
sc stop SHW_WeighingScale3kg

sc start SHW_WeighingScale30kg
sc start SHW_WeighingScale3kg

pause