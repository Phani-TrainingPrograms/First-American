using Microsoft.AspNetCore.Mvc;
using SampleMvcApp.Data;
using SampleMvcApp.Models;

namespace SampleMvcApp.Controllers
{
    public class DBFirstController : Controller
    {
        private readonly IDBFirstComponent component;

        public DBFirstController(IDBFirstComponent component)
        {
            this.component = component;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AllEmployees()
        {
            var model = component.GetAllEmployees();
            return PartialView(model);
        }

        public IActionResult AddNew()
        {
            var model = new TblEmployee();
            return PartialView(model);
        }

        [HttpPost]
        public IActionResult AddNew(TblEmployee postedData)
        {
            component.AddNewEmployee(postedData);
            return RedirectToAction("Index");
        }
        
    }
}
