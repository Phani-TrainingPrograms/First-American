# First-American
Training for First American 
.NET Framework: 
Its a technology for developing various kinds of Applications on various devices. 
It provides a capability to build Terminal Based, Web Based, Windows Based, Mobile Based and Database Centric Applications. .NET can also be used to create Micro controller level Apps. 
Its available in 2 flavors: .NET Framework and .NET CORE
.NET Framework is for Windows OS primarily. Latest version is 4.5.8. 
.NET CORE is for multiple platforms: Windows, Linux and Mac.  Latest version is .NET 7.0 but the LTS version is 6.0 as for VS 2022.
The .NET Framework is available as platform on Windows OS by default. However for other OS, U may have to download the .NET CORE from the MS Downloads Website.

C# Language:
C# is a programming language based on C++ that is used for developing .NET Applications. The language is specifically built for .NET to develop .NET Apps. It has got features from C++, Java and Visual Basic. It tries to provide pure Object oriented programming with support of automatic memory management(Garbage Collection). It has romoved some ambiguious features of C++ and provide a clean way of writing the code. Most of the features are acquired from C++. 
C# is easy to learn and work with it. We have APIs that can help to develop complex operations with small pieces of code. 
The APIs are provided by the .NET Framework and C# uses them in its code. 

Visual Studio: VS is the IDE for developing .NET Applications. Even though U can use VS code or any other Text editors for developing .NET Apps, VS is the most prefered one and is also most advanced one. We are working on VS 2022.

Features of .NET: 
1. .NET is designed to be platform independent and language independent. Use the software built in one language of .NET Framework inside the code created in another language.
2.  .NET Code is executed in a 2 step process: Every language code will be compiled by its language compiler to convert the code into a deployable unit called ASSEMBLY. 
Assembly in .NET are of 2 types: EXE or DLL. 
This assembly will have 2 parts: MSIL code(Language independent code) and Manifest (Metadata of the IL code)
When the App is executed, then the runtime environment of .NET called CLR(Comman Language Runtime) is made available to execute. It has a compiler called JIT(Just I-Time) Compiler that recompiles the IL code to the native code optimized to execute on the OS that the App is executing. This native code is optimized based on the Architecture of the OS it executes.(x86 or x64).
3. .NET Apps are said to be Memory managed Applications. U dont need to worry on the memory as it automatically handles the memory of the Application. Any heap created memory will be garbage collected with perfect algorithm so that Out of memory issues dont arise.
4. .NET Apps are designed to be Object Oriented and help in working with latest design patterns adopted in the Software development Companies. 
5. It is supported by Microsoft and has a large comunity of developers for support on .NET Applications. The MSDN(MS developer network) helps in providing Documentation and solutions to real time issues that might arise while U program.

How to develop .NET Apps in a professional manner?
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
- Every data type has a function called ToString to convert the type to String. 
- Every Value Type comes with Parse Method to convert a string to its type.
- For converting a type to any other type, we can use Convert class that has static methods to convert from one type to another.
- Certain conversions are implicit. Longer range data types can implicitly convert the lower range types. But the reverse needs a conversion.   

### Reference Types:
- These are the types that store the reference(Address) of the data. The data would be created in the Heap Area of the Memory and its reference will be available to the variable.
- All Classes are of Reference types. Other examples are Delegates,  interfaces. 
- System.Object is one important Reference type that is the base class for all types in .NET. 
- object can internally store any kind of data as everything is object in .NET.
- object comes with 4 important methods
	- GetType() used to get the internal data type of the value that is stored in the object. 
	- ToString() gets the string representation of the object. 
	- GetHashCode() gets the Unique Id of the object. The id is created by the CLR for its identification. 
	- Equals() that is used to define the logical Equivalence of a comparing object.     
- object is required when we dont know the data type at compile time.
- Major APIS of .NET which return data of different kinds would have their return type as object.
- Internally, the object stores the value as a BOXED Value. It means the object will hide the actual data type info to the user and the data type features will be lost when U work with object.
- BOXING is the term used in .NET for the implicit conversion of any type to object. The Reverse of BOXING is explicit conversion which U must do while reconverting the object back to its original type. 
- The boxed value can be UNBOXED only to that same type from which it was boxed.  Else it throws InvalidCastException.

### Enums
- Enums are User defined types that are used as Named Constants. 
- Enums internally store the values as integral types(byte, short, int and long). 
- U refer an integral value by a name(For better readability) is what makes an Enum.
- Enums are requried when U want the user input to be of a given range of values. 
- Enum values by default start with 0 and increment the next value by 1. However, U can change the start value or any intermediate value if U want using code.  
- To get info about a Enum type, we can use a Class called System.Enum that has static methods to get possible values of the enum type, and even parse the string value to the Enum type for converting string to Enum types.
     
### Arrays
- Arrays are reference types in .NET. They are formally instantiated using new operator. 
- They are not dynamic, once the array is created, U cannot modify the length of the Array.
- However, U have APIs to copy from one array to another with UR own logic of getting arrays created dynamically. 
- All arrays are instances of a class called System.Array.
- With the instance, we get Properties like Length(size of the array), Rank(Dimensions of the array) and methods like GetLength which gets the length of the specified dimension if the array is multi-dimensional, Clone, CopyTo and many more. 
- Array also has Static methods that can be used to create Array objects at runtime.
- U can create Single dimensional and multi dimensional Arrays.
- U can also array of arrays called as JAGGED Arrays. U can create an array of classrooms where each room has a array of students in it.      
#### Assignments for Day 1:
- Create an Enum for weekdays of the week and ask the User to provide the input of selected day of work to office and display the day of work.

### Functions in C#
- Functions are blocks of code that perform an operation that is to be done repeatedly across the Application at various points. 
- As C# is OOP, we have to create functions within the class only. U cannot have global functions in C# as of C#7.0 version.
- The functions could be invoked either by the instance of the class or by the ClassName. Functions invokable thru the instance are called as NonStatic or Instance based functions. Functions that are invoked by the Name of the class are called as Static functions. 
- We create static functions if we are using the function quite frequently in the Application so that U dont need an instance of the class.  
- Within Static function, U can call instance functions only thru object instances. 
- Static Functions must be called using the classname only, Unlike C++ and Java, U cannot call Static functions thru class instances. 
- Static functions are also created as Helper functions within an Application to break down complex tasks into smaller tasks.

### Parameters within Functions
- parameters are dependencies injected into a function to allow it to perform the functionality.
- By default, parameters are passed by value in C# Functions. 
	- The parameter value changes that are made in the function are not reflected outside the function.
- To give back the modified value, we use return types for the functions. A Function can have only one return type. 
- Sometimes, U may have to return multiple values for a given function call. This can be done by Pass By Reference, Pass By Out parameters in C#. ref and out are the keywords that define the ref and out parameters in C#.  
- ref and out are very similar in their functionality except that ref parameters are intialized before sending to the function. out parameters must be set with a value before exiting the function. 
- If U want the caller of the function to pass any no of arguements, U can use params.
- There can be only one params type in a function. It should be last of the parameter list. It must be always pass by value.  
  
  
### Classes and Objects:
- A Class is simply a User defined Data type that has both data(Fields) and behaviour(Functions) in it. It is a composite Data type.
- Classes are to be defined before using them. The Defining means that what the class contain, what functionalities that it pocesses to be consumed and many more. 
- A Class can contain fields, functions, events and properties. Classes can also be nested. But its scope is very limited. 
- Fields of a class are usually private. It means that they are accessible only within the class definition. U cannot refer them outside the class. This feature is called Encapsulation where the class secures the data by not allowing others to access it. 
- We use Functions to manipulate the data. Functions can be private or public. public implies that the methods are accessible any where in the program by using the object of the class.
- Old C/C++ programs had Getter/Setter Functions to provide access to the private data. However in C#, ue can use Properties which are Accessors to the private data. 
- Properties are internally blocks to get/set the private data. U can provide any business contraints so as to provide appropriate data required for UR business.
- New in C# 4.0, we have Automatic Properties where U dont need to create seperate private data, the hidden data will be provided by the .NET itself, U just have to create properties. The properties can also be accessed while creating the object using a new syntax called object initialization syntax. 
- Once the class is defined, we create objects of the class and consume the properties or access the methods using the object. Ofcourse, if U have static methods, U dont need an object for accessing it.
- Use old style properties if U want to have business rules to be implemented for the data, else U can go for new Property syntax where U just properties as accessors to the hidden data. 


### SOLID Principles:
- OOP designing is done based on the principles of the OOP called SOLID
- Single Responsibility Principle: A class should do only one JOB. Dont mix the UI interaction with the Business Logic and Business Logic with Data Storage. 
- Open Closed Principle: A class is immutable. Once created, it is closed for modification, but is open for Extension. This leads to concept of Inheritance feature in OOP. 
- Luskov's Substitution Principle: A Base type can be substituted by any of the derived types in the program as long as it does not alter the signature of the Function. 
- Interface Segregation Principle: It is better to have specfic interfaces rather than having large interface with multiple operations in it. 
- Dependency Inversion Principle: It is better to depend on abstractness rather than concreteness while defining functions within UR program. 


### SOLID Principles:
- OOP designing is done based on the principles of the OOP called SOLID
- Single Responsibility Principle: A class should do only one JOB. Dont mix the UI interaction with the Business Logic and Business Logic with Data Storage. 
- Open Closed Principle: A class is immutable. Once created, it is closed for modification, but is open for Extension. This leads to concept of Inheritance feature in OOP. 
- Luskov's Substitution Principle: A Base type can be substituted by any of the derived types in the program as long as it does not alter the signature of the Function. 
- Interface Segregation Principle: It is better to have specfic interfaces rather than having large interface with multiple operations in it. 
- Dependency Inversion Principle: It is better to depend on abstractness rather than concreteness while defining functions within UR program. 

### Inheritance:
- Inheritance is a feature of OOP where we can extend our classes without altering the signatures of the existing classes. The Class which is being extended is called as BASE/PARENT/SUPER class. The class that is extending is called as DERIVED/CHILD/SUB Class. 
- Inheritance is based on the principle of OOP called Open Closed Principle. A Class is closed for modification(IMMUTABLE) but is open for extension. 
- Inheritance in C# is Single Inheritance. UR class can have only one base class at any level. Only C++ supports multiple Inheritance. The concept creates lots of ambiguities, so it is discarded in the newer OOP languages like Java and C#. 
- C# supports Multi level Inheritance which could give U the feel of multiple inheritance in a more safer manner.

### Method Overriding
- A Class is immutable. However U can extend it. 
- If a method needs to be modified by the derived class, then U must go thru a feature called Method overriding. 
- The Base class should provide permissions for the derived classes to modify the methods. The method that is intended to be modified by the derived classes should be marked with a modifier called virtual. Only virtual methods can be modified in the derived classes. 
- The derived class can modify the methods by redefining the methods using a modifier called override.
- override can be done on those methods that are marked as virtual, override or abstract in its base class declarations.  

### Abstract classes:
- Classes that contain atleast one method that is not implemented by the class. These methods are intended to be implemented by the derived classes. 
- Non implemented method should be marked as abstract and the class becomes an abstract class. U should use abstract modifier at the class level as well as method level. 
- Abstract classes are incomplete classes, so they cannot be instantiated.
- Abstract class object can be instantiated to any of the derived classes and then consumed. 
- The classes that inherit from the abstract class must implement all the abstract methods, else even the derived class becomes abstract.

### Interfaces:
- Interfaces are like Abstract classes but will have only abstract methods in them.
- Interfaces cannot have implementations. Interfaces cannot have fields, however they can have properties. Interface members are always public. U dont mention the access specifier for the Interface methods
- A class can implement multiple interfaces at the same level. The class that implements the interface must implement all the methods of the interface with public scope. With this, the class guarantees(Like A contract) that the methods of the interface are implemented and is available at public scope.
- All interfaces are prefixed with I in C#. We dont have implements keyword, the implementation syntax is similar to Derivation Syntax 
-Interfaces can be implemented in 2 ways: Implicitly and Explicitly. Explicit Implementation would help in resolving naming conflicts for methods with same signature but provided by different interfaces.
- Interfaces are the most widely used OOP feature for developing Applications at all levels. 

### Method Hiding
- Methods that are not virtual can be modified by the derived classes. 
- In this case, the methods hide the implementation of the Base class. 
- They are not polymorphic and the methods invoked thru Base class objects will not recognize the newly implemented methods. 
- Use the new keyword for the derived class implementation if the new implementation is intended. It simply removes the warning on the method. However, it still retains the same functionality. One must avoid Method hiding as much as possible as its not a good practise of implementing OOP Features.

### Sealed Classes:
- If U have classes that U dont intend to extend, they can be marked with decorator sealed to make it non inheritable. 
- Sealed class methods cannot have abstract, virtual methods. However they can have override methods. 
- Examples of Sealed classes are string. 
- U can create Sealed methods for overridable methods, so that intension is to make the methods that are being overriden be sealed and dont want to override further.  The chain will stop. sealed methods have 2 modifiers sealed along with override. In other words, only overriden methods can be sealed. 

