# C# and .net core grade app

## How to run?
```
dotnet build
dotnet run
```

## .NET Core SDK
.NET Core SDK
.NET Core is a development platform that you can use to build command-line applications, microservices and modern websites. It is open source, cross-platform, and supported by Microsoft.


.NET: know how to bring our app to life, and send instructions to it. We can break it down to 2 main peaces: 
* CLR == Common Language Runtime. provides the space to run the program, manage memory, send instructions to the hardware.
* FCL == Framework Class Library - a library of code provided by microsoft and the community.

* The .NET manages the garbage collector, it keeps track on all the references/values ect and knows when there is no values or objects to point to. It than runs the collector to free up the memory for re-allocation.

# Basic C#
Files:
GradeBook.scproj - a c# project. can contain information about my command

# NuGet
package feed provided by microsoft and developers. Equals npm in nodejs.


# Debugging
Inside .vscode there is a file called launch.json, as part of the configurations there is an array called "args" it will mimic the cmd arguments for debugging purposes.


# References VS. Values
* Reference is a pointer to an object in memory.
* value holds a value.

![image](https://user-images.githubusercontent.com/20379084/72080211-0cc03e80-3305-11ea-8f80-f71377cd5213.png)

How to know when you are working with each? It's simple, whenever working with something that was defined by a calls - than you are working with a reference type.

If a value it of type "struct" it is a value, example: types such as bool, int,DateTime. 
*Do note - String is a class and it is ALWAYS a reference type. Its is often behaved as value type. Strings are immutable.


# A solution file
An SLN file is a structure file used for organizing projects in Microsoft Visual Studio. It contains text-based information about the project environment and project state. When opened, the preSolution, Project, and postSolution information is read from the SLN file.

# Code conventions in c#
* methods/class/filenames/public member == use Upper Case;

# Testing
[Fact] = Declares that a method is a unit test.

