# First-American
Training for First American 

###.NET Framework: 
Its a technology for developing various kinds of Applications on various devices. 
It provides a capability to build Terminal Based, Web Based, Windows Based, Mobile Based and Database Centric Applications. .NET can also be used to create Micro controller level Apps. 
Its available in 2 flavors: .NET Framework and .NET CORE
.NET Framework is for Windows OS primarily. Latest version is 4.5.8. 
.NET CORE is for multiple platforms: Windows, Linux and Mac.  Latest version is .NET 7.0 but the LTS version is 6.0 as for VS 2022.
The .NET Framework is available as platform on Windows OS by default. However for other OS, U may have to download the .NET CORE from the MS Downloads Website.

### C# Language:
C# is a programming language based on C++ that is used for developing .NET Applications. The language is specifically built for .NET to develop .NET Apps. It has got features from C++, Java and Visual Basic. It tries to provide pure Object oriented programming with support of automatic memory management(Garbage Collection). It has romoved some ambiguious features of C++ and provide a clean way of writing the code. Most of the features are acquired from C++. 
C# is easy to learn and work with it. We have APIs that can help to develop complex operations with small pieces of code. 
The APIs are provided by the .NET Framework and C# uses them in its code. 

### Visual Studio: 
VS is the IDE for developing .NET Applications. Even though U can use VS code or any other Text editors for developing .NET Apps, VS is the most prefered one and is also most advanced one. We are working on VS 2022.

## Features of .NET: 
1. .NET is designed to be platform independent and language independent. Use the software built in one language of .NET Framework inside the code created in another language.
2.  .NET Code is executed in a 2 step process: Every language code will be compiled by its language compiler to convert the code into a deployable unit called ASSEMBLY. 
Assembly in .NET are of 2 types: EXE or DLL. 
This assembly will have 2 parts: MSIL code(Language independent code) and Manifest (Metadata of the IL code)
When the App is executed, then the runtime environment of .NET called CLR(Comman Language Runtime) is made available to execute. It has a compiler called JIT(Just I-Time) Compiler that recompiles the IL code to the native code optimized to execute on the OS that the App is executing. This native code is optimized based on the Architecture of the OS it executes.(x86 or x64).
3. .NET Apps are said to be Memory managed Applications. U dont need to worry on the memory as it automatically handles the memory of the Application. Any heap created memory will be garbage collected with perfect algorithm so that Out of memory issues dont arise.
4. .NET Apps are designed to be Object Oriented and help in working with latest design patterns adopted in the Software development Companies. 
5. It is supported by Microsoft and has a large comunity of developers for support on .NET Applications. The MSDN(MS developer network) helps in providing Documentation and solutions to real time issues that might arise while U program.

### How to develop .NET Apps in a professional manner?
1. Have Visual Studio installed. It is available at cost as well as free. The community edition of the VS is free for download.
U can add additional Components required from the VS Installer like LINQ, WCF(Windows Communication Foundation). 
2. Create a Solution that contains a group of UR projects. Each Solution is a group of projects and each project has a group of files that compiles to create an Assembly(Either DLL or EXE). 
3.Make sure to open the solution or the project instead of individual files. Files cannot compile themselves. They need to be a part of the project. 
     
### How to create C# Application?
- Select the file of the type CS file. Class is the fundamental Unit of Any program in C#.
- Inside the class, we define the entry point of the Program. This is the place where UR program starts and terminates(Closes).
- We use Console class to interact with the Console window of the Application. It is a static class which has methods to read and write to the Console. This class does not need any instance to call its methods.  
- WriteLine method is used to write content on the Console Window. WriteLine method takes arg of any data type which is used to print on the Console Window. There are 19 versions of the WriteLine method. 
- Write method and WriteLine method are similar in action but WriteLine moves to the new line. 
- To Take inputs from the User, we have ReadLine method. This method captures the inputs from the Console Window and returns a string representation of it.  

### Data Types:
All Data Types in C# are based on the Common Type System(CTS) of the .NET Framework. They are broadly classified into 2 types: Value Types and Reference Types. 
Value Types are primitive Types. 
Reference types are classes and those types whose data is created in the Heap area of the Memory. 
- In value Types we have:
	- Integral Types: byte(Byte), short(Int16), int(Int32), long(Int64)
	- Floating Types: float(Single), double(Double), decimal(Decimal)
	- Other Types : char(Char), bool(Boolean), DateTime
	- User defined Types: structs and enums. 
All the data types have Wrapper Structs created in the CTS. These have functions to perform conversions, get Type info, get the Min and Max values of the type and so forth. 
- Technically, all Value types are structs and all Reference types are classes. 
