# Water_ClassProject
This is an in-class student project based on Adam Freeman's book PRO ASP.NET Core 3
https://www.apress.com/gp/book/9781484254394

## Create Solution
    dotnet new globaljson --sdk-version 3.1.101 --output TheWaterSln/Water
    dotnet new web --no-https --output TheWaterSln/Water --framework netcoreapp3.1
    dotnet new sln -o TheWaterSln
    dotnet sln TheWaterSln add TheWaterSln/Water
    dotnet new xunit -o TheWaterSln/Water.Tests --framework netcoreapp3.1
    dotnet sln TheWaterSln add TheWaterSln/Water.Tests 
    dotnet add TheWaterSln/Water.Tests reference TheWaterSln/Water
##
### Chapter 7
![image-1](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/Capture1.PNG?raw=true)

![image-2](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/Capture2.PNG?raw=true)

![image-3](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/Capture3.PNG?raw=true)

### Chapter 8
![image-4](https://github.com/ThompsonSamuel/WaterSln/blob/master/Screenshots/Chapter%208.PNG?raw=true)
