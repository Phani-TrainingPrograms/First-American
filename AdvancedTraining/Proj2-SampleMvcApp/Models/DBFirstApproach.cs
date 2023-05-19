using Microsoft.EntityFrameworkCore;
using SampleMvcApp.Data;
//Run the Following command from the Package Manager Console:
//Scaffold-DbContext "Server=.\SQLEXPRESS; Database=FaiTraining; Trusted_Connection=True; TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data
namespace SampleMvcApp.Models
{
    public interface IDBFirstComponent
    {
        void AddNewEmployee(TblEmployee emp);
        List<TblEmployee> GetAllEmployees();
    }

    public class DBFirstComponent : IDBFirstComponent
    {
        public void AddNewEmployee(TblEmployee emp)
        {
            var context = new FaiTrainingContext();
            context.TblEmployees.Add(emp);
            context.SaveChanges();
        }

        public List<TblEmployee> GetAllEmployees()
        {
            var context = new FaiTrainingContext();
            return context.TblEmployees.ToList();
        }
    }
}