using Microsoft.AspNetCore.Mvc;

namespace EmployeeCvManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}