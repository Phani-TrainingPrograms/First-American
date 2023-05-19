using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
//To transfer the data from Controller to View:
//Model object->U can have only one Model per View/Action.
//ViewBag object->A Dynamic object to store data in the form of key-value pairs
//ViewData object->Dictionary object. Both ViewBag and ViewData refer to the same Collection. The Scope of ViewBag and ViewData is limited to the action where it is declared. 
//TempData->Used to store data across multiple actions. 

//From the View to the Controller:
//Model: HTTP Post method
//FormCollection: Get the info of the Controls within the form
//Parameters : A method can have parameters matching to the IDs of the controls that post the data. 
namespace SampleMvcApp.Controllers
{
    public class CalcController : Controller
    {
        private void getItems()
        {
            var options = new List<SelectListItem>();
            options.Add(new SelectListItem { Text = "Plus" });
            options.Add(new SelectListItem { Text = "Minus" });
            options.Add(new SelectListItem { Text = "Multiply" });
            options.Add(new SelectListItem { Text = "Divide" });
            ViewBag.CalcOptions = options;
        }

        private void getTempData()
        {
            var options = new string[]
            {
                "Plus", "Minus", "Multiply", "Divide"
            };
            TempData["options"] = options;
        }
        public IActionResult Index()
        {
            //getItems();
            getTempData();
            TempData.Keep();//Ensures that the TempData values are retained. 
            return View();
        }

        public IActionResult Calculate(IFormCollection controls)
        {
            if (controls != null)
            {
                var firstValue = double.Parse(controls["txtFirstValue"]);
                var secondValue = double.Parse(controls["txtSecondValue"]);
                var options = controls["Options"];
                var result = 0.0;
                switch (options)
                {
                    case "Plus": result = firstValue + secondValue; break;
                    case "Minus": result = firstValue - secondValue; break;
                    case "Multiply": result = firstValue * secondValue; break;
                    case "Divide": result = firstValue / secondValue; break;
                    default:
                        break;
                }
                //Send the data to the View...
                ViewData["Result"] = result;
            }
          TempData.Keep();
          //getItems();
          return View("Index");
        }
    }
}
