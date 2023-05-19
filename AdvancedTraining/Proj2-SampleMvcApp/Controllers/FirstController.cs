using Microsoft.AspNetCore.Mvc;
using SampleMvcApp.Models;

namespace SampleMvcApp.Controllers
{
    //Controller is simply a .NET Class that is derived from MS.ASPNetCore.Mvc.Controller
    //The functions of the controller that processes requests are called as ACTIONS. 
    public class FirstController : Controller
    {
        public string HelloWorld() => "Hello World";

        public int AddValues() => 123 + 234;

        public Employee DisplayDetails() => new Employee 
        {
            Address = "Bangalore", EmpId = 123, MobileNo = 9945205684, Name="Phani Raj", Salary = 56000
        };
        
        //The ViewResult is a Class that represents a View for the Action
        public ViewResult DisplayEmployee()
        {
            var model = new Employee
            {
                Address = "Bangalore",
                EmpId = 123,
                MobileNo = 9945205684,
                Name = "Phani Raj",
                Salary = 56000
            };
            return View(model);//View is a function of the controller class that returns a View for the User with name of the Action. 
        }

        public ViewResult AllEmployees()
        {
            var model = new Employee[]
            {
                new Employee{ Address ="MYS", EmpId = 1, MobileNo = 23423423, Name ="Suraj", Salary = 4000   },
                new Employee{ Address ="BLR", EmpId = 2, MobileNo = 23423423, Name ="Neeraj", Salary = 4000   },                
                new Employee{ Address ="CHE", EmpId = 3, MobileNo = 23423423, Name ="Dheeraj", Salary = 4000   },                
                new Employee{ Address ="HYD", EmpId = 4, MobileNo = 23423423, Name ="David", Salary = 4000   },                
                new Employee{ Address ="PUN", EmpId = 5, MobileNo = 23423423, Name ="Ram", Salary = 4000   }
            };
            return View(model);
        }
    }
}
