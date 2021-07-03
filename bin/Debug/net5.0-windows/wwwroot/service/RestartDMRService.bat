@echo off
color 2
title Restart services: SHW_AutoRestartService, SHW_WeighingScale30kg, SHW_WeighingScale3kg

sc stop SHW_WeighingScale30kg
sc stop SHW_WeighingScale3kg

sc start SHW_WeighingScale30kg
sc start SHW_WeighingScale3kg

pause