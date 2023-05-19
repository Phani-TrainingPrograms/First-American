using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleMvcApp.Models
{
    public enum LoanType { House, Vehicle, Personal };

    [Table("tblLoan")]
    public class LoanApp
    {
        [Key]
        public int Id { get; set; }
        public string Applicant { get; set; } = string.Empty;
        public int AmountOfLoan { get; set; }
        public string Address { get; set; } = string.Empty;
        public string KindOfLoan { get; set; } = LoanType.House.ToString();
        public bool IsEligible { get; set; } = true;
        public string FailureDescription { get; set; } = string.Empty;
    }

    public class LoanDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string STRCONNECTION = @"Data Source=.\SQLEXPRESS; Initial Catalog= FaiTraining; Integrated Security = True; TrustServerCertificate=True";
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(STRCONNECTION);
        }

        public DbSet<LoanApp> Loans { get; set; }
    }

    public interface ILoanComponent
    {
        void AddNewApplication(LoanApp app);
        void UpdateLoanApplication(LoanApp app);
        void DeleteApplication(int appId);
        List<LoanApp> GetAllApplications();
        List<LoanApp> FindAllEligibleApplications();
        List<LoanApp> FindAllFailedApplications();
    }

    public class LoanComponent : ILoanComponent 
    {
        private readonly LoanDbContext context;
        public LoanComponent()
        {
            context = new LoanDbContext();
        }

        public void AddNewApplication(LoanApp app)
        {
            context.Loans.Add(app);
            context.SaveChanges();
        }

        public void DeleteApplication(int appId)
        {
            var loan = context.Loans.FirstOrDefault((l) => l.Id == appId);
            if (loan != null)
            {
                context.Loans.Remove(loan);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Loan Details not found to delete");
            }
        }

        public List<LoanApp> FindAllEligibleApplications()
        {
            var loans = context.Loans.Where((l) => l.IsEligible == true);
            return loans.ToList();
        }

        public List<LoanApp> FindAllFailedApplications()
        {
            var loans = context.Loans.Where((l) => l.IsEligible == false);
            return loans.ToList();
        }

        public List<LoanApp> GetAllApplications() => context.Loans.ToList();

        public void UpdateLoanApplication(LoanApp app)
        {
            
        }
    }
}
