using System;
using EmployeeCvManager.Helpers;
using EmployeeCVManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCvManager.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly string _scriptString;
        private readonly FrontendScriptsHelper _frontendScriptHelper;
        public HomeController (FrontendScriptsHelper frontendScriptHelper){
            _frontendScriptHelper = frontendScriptHelper;
            _scriptString = _frontendScriptHelper.GetScriptTagString();
        }
        [Route("{*.}", Order = Int32.MaxValue)]
        public IActionResult Index()
        {
            return View(new HomeModel(){
                ScriptString = new HtmlString(_scriptString)
            });
        }
    }
}