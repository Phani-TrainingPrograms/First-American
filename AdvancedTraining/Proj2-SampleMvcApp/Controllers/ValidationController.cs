using Microsoft.AspNetCore.Mvc;
using SampleMvcApp.Models.Validation;

namespace SampleMvcApp.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult RegisterEmployee()
        {
            var emp = new Employee();
            return View(emp);
        }

        [HttpPost]
        public IActionResult RegisterEmployee(Employee posted)
        {
            if(ModelState.IsValid) 
            {
                ViewBag.Success = "Employee registered Successfully";
                return View(posted);
            }
            else
            {
                ViewBag.ErrorMessage = "Validation Failed for the Registration";
                return View(posted);
            }
        }
    }
}
