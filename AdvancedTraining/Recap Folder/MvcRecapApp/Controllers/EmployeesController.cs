using Microsoft.AspNetCore.Mvc;
using MvcRecapApp.Models;
//1. EF Packages
//2. Generate the Tables in the database
//3. Use the context to interact with the DB..
namespace MvcRecapApp.Controllers
{
    public class EmployeesController : Controller
    {
        /// <summary>
        /// Action to get All the Employees from the Data Source
        /// </summary>
        /// <returns>View with all the data</returns>
        public IActionResult Index()
        {
            var context = new EmployeeDBContext();
            var model = context.Employees.ToList();
            return View(model);
        }

        public IActionResult OnFind(int id)
        {
            var context = new EmployeeDBContext();
            var record = context.Employees.FirstOrDefault(r=>r.EmpId == id);
            if (record == null)
            {
                throw new Exception("No Record is found");
            }
            return View(record);
        }

        [HttpPost]
        public IActionResult OnFind(Employee postedData)
        {
            var context = new EmployeeDBContext();
            var rec = context.Employees.FirstOrDefault(rec => rec.EmpId == postedData.EmpId);
            if(rec != null)
            {
                rec.EmpName = postedData.EmpName;
                rec.EmpEmailAddress = postedData.EmpEmailAddress;
                rec.EmpSalary = postedData.EmpSalary;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(postedData);
            }
        }

        public IActionResult OnAddNew()
        {
            var model = new Employee();
            return View(model);
        }

        [HttpPost]
        public IActionResult OnAddNew(Employee postedRec)
        {
            var context = new EmployeeDBContext();
            context.Employees.Add(postedRec);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
