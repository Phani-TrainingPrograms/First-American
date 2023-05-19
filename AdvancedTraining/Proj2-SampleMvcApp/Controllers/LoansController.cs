using Microsoft.AspNetCore.Mvc;
using SampleMvcApp.Models;

namespace SampleMvcApp.Controllers
{
    public class LoansController : Controller
    {
        private readonly ILoanComponent component;
        public LoansController(ILoanComponent component)
        {
            this.component = component;
        }

        public ViewResult GetAll()
        {
            var model = component.GetAllApplications();
            return View(model);
        }

        public IActionResult OnAddNew()
        {
            var loanTypes = Enum.GetValues(typeof(LoanType));
            ViewBag.LoanType = loanTypes;//Additional data that is sent to the View
            var model = new LoanApp();
            return View(model);
        }

        [HttpPost]
        public IActionResult OnAddNew(LoanApp postedData)
        {
            try
            {
                component.AddNewApplication(postedData);
                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        public IActionResult OnEdit(int id)
        {
            var all = component.GetAllApplications();
            var appForm = all.Find(a => a.Id == id);
            return View(appForm);
        }

        [HttpPost]//Called when the user submits
        public IActionResult OnEdit(LoanApp app)
        {
            try
            {
                component.UpdateLoanApplication(app);
                return RedirectToAction("GetAll");
            }
            catch(Exception ex) 
            {
                ViewBag.Message = ex.Message;
                return View(app);
            }
        }
    }
}
