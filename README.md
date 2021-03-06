# Water_ClassProject
This is an in-class student project based on Adam Freeman's book PRO ASP.NET Core 3
https://www.apress.com/gp/book/9781484254394

## ScreenShots
1. [Chapter 7](#Chapter-7)
2. [Chapter 8](#Chapter-8)
3. [Chapter 9](#Chapter-9)
4. [Chapter 10](#Chapter-10)

## Create Solution
    dotnet new globaljson --sdk-version 3.1.101 --output TheWaterSln/Water
    dotnet new web --no-https --output TheWaterSln/Water --framework netcoreapp3.1
    dotnet new sln -o TheWaterSln
    dotnet sln TheWaterSln add TheWaterSln/Water
    dotnet new xunit -o TheWaterSln/Water.Tests --framework netcoreapp3.1
    dotnet sln TheWaterSln add TheWaterSln/Water.Tests 
    dotnet add TheWaterSln/Water.Tests reference TheWaterSln/Water
##

<a name="Chapter-7"/>

## Chapter 7
![image-1](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/Capture1.PNG?raw=true)
![image-2](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/Capture2.PNG?raw=true)
![image-3](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/Capture3.PNG?raw=true)

<a name="Chapter-8"/>

## Chapter 8
![image-4](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/Capture%205.PNG?raw=true)
![image-4](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/Capture%206.PNG?raw=true)
![image-4](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/Capture7.PNG?raw=true)

<a name="Chapter-9"/>

## Chapter 9
![9-4](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/9-4.PNG?raw=true)
![9-5](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/9-5.PNG?raw=true)
![9-6](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/9-6.PNG?raw=true)
![9-Tests](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/Test%20-%209.PNG?raw=true)

<a name="Chapter-10"/>

## Chapter 10
![10-1](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/10-1.PNG?raw=true)
