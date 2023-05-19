//All .NET Core apps use Entity Framework Core 6.0 for database connectivity. EF is a Data Access model for multiple databases using ORM methodology. ORM stands for Object Relational Mapping.
//.NET has 2 Frameworks for ORM: LINQ to SQL(.NET Framework) and EF(For all kinds of databases on all platforms). 
//ORM help in representing data of the application in the form of collection objects and storage in the form of database tables.
//Table representation will be a class and Rows representation will be a collection object with the data as the elements of the collection. 
//EF supports 2 modes of ORM programming: Code First Approach and DB First Approach. DB First Approach is used when U already have the database and tables created for which U bind the data as collection using EF Tools. The reverse of it is Code First Approach.
//The EF tools required for interacting with the database are:
//EFCore, EFCore.SqlServer, EFCore.Tools
//use the Package Manager Console Window and run the following commands:
//Install-Package Microsoft.EntityFrameworkCore
//Install-Package Microsoft.EntityFrameworkCore.SqlServer
//Install-Package Microsoft.EntityFrameworkCore.Tools
using SampleCoreApp;

var component = new BookStoreComponent();
component.UpdateBook(new Book { BookId = 2,  Title="Harry Potter, Philosopher's Stone", Author="JK Rowling", Price = 250 });
var books = component.GetAllBooks();
foreach (var book in books)
{
    Console.WriteLine(book.Title);
}