using Microsoft.AspNetCore.Mvc;

namespace Team4_Final_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}