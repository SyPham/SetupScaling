@echo off
color 2
title Destroy duplicate service
sc stop SHW_IoT_WS_Service162
sc stop SHW_IoT_WS_Service163

sc delete SHW_IoT_WS_Service162
sc delete SHW_IoT_WS_Service163


pause