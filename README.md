# EGearRatioTool
計算伺服馬達電子齒輪比的小工具

![](https://i.imgur.com/bmgr4BI.png)

1. 輸入每1mm的使用者單位量
2. 減速比，以7比減速機為例，負載側轉一圈，馬達需要轉7圈，就輸入 1/7
3. 輸入螺杆導程
4. 輸入伺服編碼器的每圈脈衝數，以三菱JE C為例，輸入131072
5. 輸入伺服馬達的最高轉速，以供計算1秒的參考最大移動量
---
The tool to compute the E-Gear ratio for Servo
1. Input the PUU/mm
2. Input the redution ratio. E.g. 7 revolutions on motor results in 1 resolution on load shaft, input 1/7 here.
3. Input the pitch of transimission screw.
4. Input the encoder resolution, PLS/motor revolution. E.g. 131072 PLS/rev for mitsubishi JE C Servo.
5. Input the max RPM for the servo motor. This is used to compute the ref. max moving distance in 1s servo operation.
