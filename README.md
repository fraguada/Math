# Math
some tests to try and use c++ methods form a net7.0 Android app

## projects

- MathLibrary - The c++ project with exported functions
- MathCommon - .NET Framework project which wraps MathLibrary
- MathCommonNetCore - .NET Core project which wraps MathLibrary (duplicate of MathCommon, just to check other dotnet flavors)
- MathConsole - .NET Framework console app that calls MathCommon. Working with the add method in MathLibrary.
- MathConsoleNet - .NET Core console app that calls MathCommonNetCore. Working with the add method
- AndoidMathApp - Calls MathCommonNetCore. Getting DLLNotFound Exception from MathCommonNetCore on the add method.

## tools
![image](https://user-images.githubusercontent.com/1014562/222543267-e75d0264-d1b4-4304-a7e3-7960438434e9.png)

![Screenshot 2023-03-02 184833](https://user-images.githubusercontent.com/1014562/222542659-2b2a2f31-3940-4150-89a8-40f91d17ff58.png)

## build
all projects build to the main bin folder. MathLibrary dll, lib, and other files should be manually copied to the MathConsoleNet and AndroidMathApp (though it is failing anyways)

