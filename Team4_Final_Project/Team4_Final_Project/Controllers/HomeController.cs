using Microsoft.AspNetCore.Mvc;

namespace Team4_Final_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated == false)
            {
                RedirectToAction("Login", "Account"); 
            }
            
            if (User.IsInRole("Customer"))
            {
                // TODO: check to see if customer has accounts, then redirect to account management page
                return RedirectToAction("Create", "Accounts");
            }

            return View();
        }
    }
}