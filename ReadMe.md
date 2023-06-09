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
- If a class contains only static members in it, it is better to create the class as static so that the user need not create the instance of the class as the members are available only by the name of the class. 

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

### Constructors
- Constructors are sp functions created to inject the dependencies required for the object to be usable.
- Constructor with no args is called as DEFAULT Constructor. 
- Constructors can be parameterised. Any dependencies for the class is injected using the parameters of the Constructor. 
- Constructors follow a hierarchy chain while creating the object. If the current class has a base class, then the base class's default constructor will be called. However, if the base class has constructors being OVERLOADED, U can specify which constructor to call by invoking the base class constructor explicitly using base keyword. 
- If the base class has only parameterised constructor, then it is the responsibility of the derived class to explicitly invoke the base class constructor from its contructor using base keyword. 

### Exception handling
- Exceptions are abnormal termination when an App fails to take it forward because of a wrong input, or a condition where the Application cannot be taken forward.
- Exceptions in C# are object oriented classes. Any Exception is raised using an object of a class derived from System.Exception. 
- throw keyword is used to raise an Exception in the code. 
- Exceptions are handled using try....catch...finally. The code can have a try block followed by catch or finally or both.
- try block can have multiple catch blocks but only one finally block. try blocks can be nested.
- If a code raises an Exception, first it checks within the executing block whether the Exception can be handled or not. If not found, it raises to the caller of the function, if not found there it continues its funnelling of the Block until it reaches the Main function. Even if the Main does not have the Exception Handling code, the Application will terminate with the Error code of a -ve no. 

# Week 2
## Frameworks
### Collections Framework
- Collections provide a set of classes and interfaces that will resolve the limitations of Arrays. 
- Collections are available in 2 flavors: Generic and Non Generic. 
- Non Generic is the old version and is almost replaced by Generic Version.
- Non Generic collections store the data in the form of objects. They are slow as BOXING and UNBOXING was required while storing and reading the data respectively. They store the data as objects, there could be a possibility of storing data of multiple data types within the collection and would not be typesafe.
- The namespace for Non Generic collections is System.Collections
- Important classes: ArrayList, HashTable, Stack, Queue. 
- Even though Generic Collections are used widely, they are internally inherited or implementing the interfaces of the Non Generic Collection Classes. 
- Generic collections are typesafe as they store the specific kind of data in it. The data type is determined at compile time so that U can insert/remove only the data of that specific type.  There is no scope of BOXING/UNBOXING in Generic Collections. Its faster and easy to maintain. Generic collections came into the .NET from .NET v2.0(2005)
- List<T> is a generic class that works like Array but with additional features to add/remove elements within the collection even after creating it. It has methods to add, insert, remove, removeat and Properties like Count to get the size of the elements and many more. List<T> implements IList<T> interface which internally derives from ICollection<T> and so forth
- List<T>--->IList<T>---->ICollection<T>---->IEnumerable<T>--->IEnumerable
- HashSet<T> is a data structure similar to List<T> but will store unique values in it. List<T> has a limitation of storing duplicate values. With HashSet<T>, U can resolve it, hashset works very similar to List<T>. 
- When a new object is created, the CLR will create unique ID for the object. This is called as HashCode. HashSet checks for HashCode to see if they are the same objects. If the hashcode of 2 objects are same, then the Hashset looks for the logical equivalence of those 2 objects which is defined in the Equals method of the object. After this, the Hashset determines whether the object is same or different.
- Dictionary<K,V> is like Hashmap where the data is stored in the form of key-value pairs. Dictionary is faster and easy to work with. It has APIs to Add, Remove and search the Data based on Key or Value. It has ContainsKey Function to check if the collection already has the Key or not. As Key is unique to the collection, it would throw an Exception if you try to insert a duplicate key. 
- Queue<T> is a data structure that stores the data in the form of First-In-First Out mechanism. Elements will be added to the bottom of the Queue and the first element will be ejected from the Queue. 
- Enqueue method is used to add an element to the Queue, Dequeue removes the first element in the Queue. U cannot remove any intermediate elements from the Queue.
- Stack<T> is another datastructure used to store the elements like a pile of Stack. It adds the Items to the top of the Collection and removes the last item added to the Collection. 
- SortedList and SortedDictionary are used to create Key-Value pair collections which should be in sorted manner. The Sorting is based on key. SortedList works in 2 ways, with index as well as key. So with index, it works like list<T> and with Key it works like dictionary. SortedDictionary is used like Dictionary only where the iteration happens with Key only. Internally SortedDictionary is not stored as Continuous Memory but SortedList is stored as continuous memory. 

### Comparing Objects
- We need to compare objects if you want to sort the collections. 
- .NET has 2 Interfaces: IComparable<T> and IComparer<T>
- IComparable will be used if you want to implement default comparision for the Class that you are comparing. 
- IComparer<T> is used if you want objects to be compared on mutliple conditions. 
- The Sort method of the IList uses multiple overloaded versions. Default Sort will use the object's IComparable Implementation and parameterized Sort which takes IComparer as arg will use the Conditional Comparision.
- Realtime Apps use both IComparer and IComparable for providing Components that allow sorting on multiple criteria. 

### Delegates
- Similar to Function pointers of C++.  Delegates allow to have functions to be passed as arguments to other functions. They are used for creating Callback functions. Events, Multi Threading are some of the examples of using delegates practically. 
- Callback are functions that are called by the called Function after a certain task, action or any activity is completed. A function calls a function which internally will call another function that is passed as arguement. 
- .NET offers 2 builtin Generic Delegates called Action and Func. Action is used for void Functions and Func is used for non void Functions. 
-If a Delegate object is associated with mutliple Functions at a time, its called Multicast Delegate. It uses += operator to associate multiple functions for the delegate object. 

### Events:
- Events are instances of the delegates that are used as Callback functions at the class level. 
- Events are actions performed on the object by the users of the object. 
- Events are widely used in GUI based Applications. GUI Apps have controls and controls have events in them. Programmers create Event Handlers to those events and expect the End-User of the Application to trigger that event on which the Event Handler would be invoked.
- Events in C# are implemented using Delegates. Delegates point to a function, in this case, the function would be an Event handler. The function is triggered when an operation is conducted  by the user of the class. 


### File IO
- System.IO contains the classes required for performing file related operations on UR Machine. 
- File is a static class that contains APIs for reading and wrting text files in UR Application.
- Internally .NET uses Streams to perform IO operations on Files. Streams are contigenous memory that works unidirectionally from the App to the destination or from the Source to the App. Anything coming into the App is called as InputStream and anything that goes out of the App is called OutputStream. 
- Stream is an abstract class that can be associated with any kind of file. Binary files and Text files are major classifications of the files.
- FileStream is a class that works with files for performing all kinds of operations including Binary operations and Text based Operations. 
- StreamReader and StreamWriter are the classes used for reading and Creating Text based Files.
- However, for convinience, .NET has a class called File that contains APIs for operating on Text Based Files.
- For reading Folders, we have Directory class that has static APIs for reading and creating folders and sub Folders in .NET. It also has APIs to find the File Listings and its reading process.  

### Serialization:
- Storing the object itself instead of data is called as Serialization. Hibernation is one of the pratical examples of using serialization. 
- Examples would be a scenario where I want to get the same page of the website when I revisit the site again. 
- Notepad++.exe has Serialization in it. 
- All technologies internally have Serialization for Inter Process communication. We have Serialization in Java and C++ also. 
- Serialization in .NET can be achieved in 4 ways: Binary, XML, SOAP and JSON.
- For any Serialization U should have the 3 steps in it
	- Object to Serialize?(What)
	- Location of the Serialization(Where)
	- Format of Serialization(How)
- For Binary Serialization: System.Runtime.Serialization.Formatters.Binary
- For Xml Serialization: System.Xml.Serialization;
- For SOAP :  System.Runtime.Serialization.Formatters.SOAP
- For JSON : NewtonSoft.Json.Serialization.(External Library)
- For Binary Serialization, the Class of the object that U want to serialize should be having an attribute called [Serializable]. This attribute adds some abstract logic to make the objects of this class Serializable.
- For Xml and Soap Serialization, the class should be public, the Serializable attribute need not be placed.
-Use Xml and Soap for cross platform data sharing and binary serialization for Windows specific data sharing. 

### Dll Programming:
- Dll means a pre compiled Unit that can be used in a language independent manner across multiple projects.
- Dlls are files saved as .dll. They are created to make the Projects more modular and maintainable. Making Dlls will reduce the size of the EXE and dlls are loaded at runtime when the Exe begins. 
- Dlls are not executables, they are consumed by Executables.
- Class Library Project template should be used for creating Dlls.
- Classes created in the DLL projects should be public, else they will be internal to the project itself. If internal, the class is non-accessible in other projects. 
- It is good to create an Application with Dlls rather than have one big monolithic Application which is big is size. 
- Once the Dll project is built, U can consume the DLL in other projects. If the DLL project is in the same soln of the Exe Project, then U can reference the dll from the Project Tab of the Add Reference Dialog. If the Dll project does not exist in the soln, U can refer the dll by browsing the Dll location. 
- After adding the reference, U should use the namespace of the class that U want to consume and work with it as if its your own class. 

## ADO.NET
### Connected Model
- ADO.NET is the data access Model for all .NET Applications. There are other frameworks like LINQ and Entity Framework that will covered later.
- ADO.NET uses Connected and Disconnected model for database interactions.
- Connected Model is where we make an exclusive connectivity to the database, perform the relevant operations and close the connection after the work. 
- Important Classes: SqlConnection, SqlCommand and SqlDataReader. The classes are avaiable under System.Data.SqlClient namespace and the DLL is System.Data. 
- SqlConnection has ConnectionString property that is used to set the info related to the Connectivty of the Database, in our case SQL server. Its Open and Close methods are used to Open and Close the Database Connectivity. Its State property is used to get the connectivity Status of the Connection like Open, Closed, Broken and so forth. 
- SqlCommand Class represents the Queries that U make to the database. It has an association relation with the Connection Class using Connection property. The CommandText property is used to set the SQL Statement to execute. The CommandType Property is used to mention the Stored Procedure if we are using Stored Procedure to execute the Statement, in this case, the CommandText would contain the Name of the Stored Proc that we want to execute. 
- The SqlCommand class has 3 ways to execute the SQL statement
	- ExecuteNonQuery -> For Insert, Delete and Update Statements
	- ExecuteReader -> For SELECT statements where we get a reader object thru which we read the data extracted from the SELECT
	- ExecuteScalar -> For Single values retrieved from the Database like Scalar Values.
- The SqlCommand also has Parameters Collection that is used to set parameters to the Stored procedure or to the Statement that U use. It has a property called Parameters of the type SqlParameters Collection which has methods like AddWithValue to set the name and the value for the parameters to the Query. 
- SqlDataReader object is used to read the Data in a forward only and Read only manner. Its Read method is used to move the Cursor of the Data to the next while reading the Current record. 
	




