using Microsoft.AspNetCore.Mvc;
using MVC_Day1.Models;
using System.Diagnostics;

namespace HelloWorld.Controllers
{
public class HomeController: Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GotoHome()
        {
            return View("HomePage");
        }
    }
}
