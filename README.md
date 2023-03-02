# Math
some tests to try and use c++ methods form a net7.0 Android app

## projects

- MathLibrary - The c++ project with exported functions
- MathCommon - .NET Framework project which wraps MathLibrary
- MathCommonNetCore - .NET Core project which wraps MathLibrary (duplicate of MathCommon, just to check other dotnet flavors)
- MathConsole - .NET Framework console app that calls MathCommon. Working with the add method in MathLibrary.
- MathConsoleNet - .NET Core console app that calls MathCommonNetCore. Working with the add method
- AndoidMathApp - Calls MathCommonNetCore. Getting DLLNotFound Exception from MathCommonNetCore on the add method.

## build
all projects build to the main bin folder. MathLibrary dll, lib, and other files should be manually copied to the MathConsoleNet and AndroidMathApp (though it is failing anyways)