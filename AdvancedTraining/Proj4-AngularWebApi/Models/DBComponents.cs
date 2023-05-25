using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularWebApi.Models
{
    [Table("EmpTable")]
    public class EmpClass
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; } = string.Empty;
        public string EmpAddress { get; set; } = string.Empty;
        public string EmpImage { get; set; } = string.Empty;

        public int EmpSalary { get; set; }

    }

    public class EmpDbContext : DbContext
    {
        public DbSet<EmpClass> EmpData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string conString = @"Data Source=.\SQLEXPRESS; Initial Catalog= FaiTraining; Integrated Security = True; TrustServerCertificate=True";
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(conString);
        }
    }

    public interface IEmpComponent
    {
        List<EmpClass> GetEmployees();
        EmpClass GetEmployee(int id);
        void AddEmployee(EmpClass emp);
        void UpdateEmployee(EmpClass emp);
        void DeleteEmployee(int id);    
    }

    public class EmpComponent : IEmpComponent
    {
        public void AddEmployee(EmpClass emp)
        {
           var context = new EmpDbContext();
            context.EmpData.Add(emp);
            context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var context = new EmpDbContext();
            var rec = context.EmpData.FirstOrDefault(e => e.EmpId == id);
            if (rec != null)
            {
                context.EmpData.Remove(rec);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Employee not found to delete");
            }
        }

        public EmpClass GetEmployee(int id)
        {
            var context = new EmpDbContext();
            var rec = context.EmpData.FirstOrDefault(e => e.EmpId == id);
            if (rec != null)
            {
                return rec;
            }
            else
            {
                throw new Exception("Employee not found to delete");
            }
        }

        public List<EmpClass> GetEmployees()
        {
            var context = new EmpDbContext();
            return context.EmpData.ToList();
        }

        public void UpdateEmployee(EmpClass emp)
        {
            var context = new EmpDbContext();
            var rec = context.EmpData.FirstOrDefault(e => e.EmpId == emp.EmpId);
            if (rec != null)
            {
                rec.EmpName = emp.EmpName;
                rec.EmpImage = emp.EmpImage;
                rec.EmpAddress = emp.EmpAddress;
                rec.EmpSalary = emp.EmpSalary;
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Employee not found to update");
            }
        }
    }
}