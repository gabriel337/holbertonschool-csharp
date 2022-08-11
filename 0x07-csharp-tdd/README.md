# 0x07. C# - Test Driven Development
## Resources
### Read or watch:

* Unit Testing Tutorial for C# Developers (0:00 to 12:16)
* TDD Basics with C#
* Unit Testing C# with NUnit and .NET Core
* NUnit Documentation
* NUnit.Framework Documentation
* NUnit Cheat Sheet
* When to use static classes in C#
* Target .NET Frameworks
# Learning Objectives
At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

## General
* What are solutions in VSCode
* How are solutions different from projects in VSCode
* What is a class library
* What is a unit test
* What are the benefits of unit testing
* How to create and run tests using NUnit
* What is the Arrange, Act, Assert methodology
* How to effectively name your unit tests
* How to utilize the TDD approach
* How to consider edge cases
# Requirements
## C# Tasks
* Allowed editors: Visual Studio Code
* All files will be compiled on Ubuntu 14.04 LTS using dotnet
* A README.md file, at the root of the folder of the project, is mandatory
* All default C# files named Program.cs should be renamed to the name given in each task
* Each C# task requires its own folder and .sln file. Push all task folders to your GitHub and ensure the task names on the folders are correct
* You do not need to push your obj/ or bin/ folders
* In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples
* All your public classes and their members should have XML documentation tags
* All your private classes and members should be documented but without XML documentation tags
## C# Tests
* Allowed editors: Visual Studio Code
* All tests should be inside a separate folder and named as specified in each task
* All your test files will be executed using dotnet test
* We strongly encourage you to work together on tests so that you don’t miss any edge cases
# More Info
In past C# assignments, you have been creating individual console application projects for each task. In this assignment, you are going to create a solution file to allow you to manage multiple projects. Each task is one solution containing two projects: one class library solving the task and one test library to test the class library.

For each task in this project:

1. Create task directory (ex: 0-add)
2. Inside that directory, run dotnet new sln
3. reate a new directory for your task solution based on the namespace given (ex: MyMath). This directory will hold your new standard class library.
4. Inside that directory, run dotnet new classlib. Rename the resulting .cs file after the namespace (ex: MyMath.cs)
5. Enable XML documentation by adding <DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile> to MyMath.csproj
The target framework for this standard class library should be netstandard2.0
6. Change directory back to the root directory of the task (ex: 0-add) and run dotnet sln add <classlibrary/classlibrary.csproj> (ex. dotnet sln add MyMath/MyMath.csproj)
7. Create a new directory for your tests based on the namespace given plus .Tests (ex: MyMath.Tests). This directory will hold your test library.
The target framework for this library should be netcoreapp2.1
8. Inside that directory, run dotnet new nunit. Rename the resulting .cs file after the namespace of classes you are testing plus .Tests (ex: MyMath.Tests.cs)
9. To add your class library as a dependency to the project, run dotnet add reference <../classlibrary/classlibrary.csproj> (ex: dotnet add reference ../MyMath/MyMath.csproj)
10. In the task’s root directory, run dotnet sln add <testlibrary/testlibrary.csproj (ex: dotnet sln add MyMath.Tests/MyMath.Tests.csproj)
11. If you’d like to run your class library method in a console application, create a new directory and run dotnet new console inside it. Run dotnet add reference <../classlibrary/classlibrary.csproj> and you can then call your class library methods inside the console application.
For more detail, read the Unit Testing C# with NUnit and .NET Core tutorial.