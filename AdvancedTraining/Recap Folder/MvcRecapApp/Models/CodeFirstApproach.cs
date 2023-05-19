using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MvcRecapApp.Models
{
    
    /// <summary>
    /// Class that represents UR Table in the database
    /// </summary>
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; } = string.Empty;
        public string EmpEmailAddress { get; set; } = string.Empty;
        public int EmpSalary { get; set; }
    }

    //Create the DBContext class that defines the Collection Class and ORM
    public class EmployeeDBContext : DbContext
    {
        //Create a Collection Property for all the records of the table
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string strConnection = @"Data Source=.\SQLEXPRESS; Initial Catalog= FaiTraining; Integrated Security = True; TrustServerCertificate=True";
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(strConnection);
        }
    }
}