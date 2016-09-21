using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCvManager.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [Route("{*.}", Order = Int32.MaxValue)]
        public IActionResult Index()
        {
            return View();
        }
    }
}