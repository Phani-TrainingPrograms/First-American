using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCoreApp
{
    [Table("tblBook")]
    internal class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int Price { get; set; }

    }

    //DBContext class is the one that connects to the actual Database and UR Application. 
    internal class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //
            var strConnection = @"Data Source=.\SQLEXPRESS; Initial Catalog= FaiTraining; Integrated Security = True; TrustServerCertificate=True";
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(strConnection);
        }
        //Build the Application without any errors.
        //Run the following commands from the PMC:
        //add-migration migrationName_v1
        //update-database
    }

    internal class BookStoreComponent
    {
        public void AddNewBook(Book book)
        {
            var context = new BookContext();
            context.Books.Add(book);    
            context.SaveChanges();
        }

        public List<Book> GetAllBooks() => new BookContext().Books.ToList();

        public void UpdateBook(Book book)
        {
            var context = new BookContext();
            var foundBook = context.Books.FirstOrDefault((b)=>b.BookId == book.BookId);
            if (foundBook != null)
            {
                foundBook.Title = book.Title;
                foundBook.Author = book.Author;
                foundBook.Price = book.Price;
                context.SaveChanges() ;
            }
            else
            {
                throw new Exception("Book not found to update");
            }
        }

        public void DeleteBook(int id)
        {
            var context = new BookContext();
            var foundBook = context.Books.FirstOrDefault(b=>b.BookId==id);
            if(foundBook != null)
            {
                context.Books.Remove(foundBook);
                context.SaveChanges();
            }
        }
    }
}
