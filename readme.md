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
* Interface should start with a capital I -> example "public interface IBook"

# Testing
[Fact] = Declares that a method is a unit test.

# C# Method overloading
Method Overloading is the common way of implementing polymorphism. It is the ability to redefine a function in more than one form. A user can implement function overloading by defining two or more functions in a class sharing the same name. C# can distinguish the methods with different method signatures.

```
public string AddGrade(char letter, int x) {
    return " ";
}

public void AddGrade(char letter) {
   console.WriteLine($"The grade's letter is: {letter}");;
}
```

## events
* delegate give us the ability to point to or invoke different method. it is a method in a specific shape.
```
    // define the delegate field
    public delegate string WriteLogDelegate(string logMessage;

    // implementation and usage example:
    Note that is OK that the name is not the same. What's important is the return value and the function signature
     
            int count = 0;
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount ;

            var result = log("Hi, I am a log message!");

            Assert.Equal(3, count);
        }

        private string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }
        private string ReturnMessage(string message)
        {
            count++;
            return message;
        }
```

## The 3 Pillars of OOP
1. Encapsulation - allow us to hide details about our code and who sees each member of a class. It give us explicate control over our members, functions and fields. Good encapsulation is the key to good software design.
2. Inheritance - give us the ability to reuse code across similar classes. 
3. Polymorphism - allow us to have object of the same type to behave differently.

* Using the virtual keyword - its a way in c# to say here is a method that in this class but a derive calls may choose to override the implementation details of the the method. Events and properties can also be virtual.