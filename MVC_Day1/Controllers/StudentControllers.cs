using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Day1.Models;

namespace MVC_Day1.Controllers
{
    public class StudentControllers : Controller
    {
        public ActionResult Index()
        {
        return View(); 
        }
        public ActionResult Enter()
        {
            return View();
        }
        public ActionResult Submit()
        {
            
            Student obj = new Student();
            obj.StudentRollNo = Request.Form["StudentRollno"];
            obj.StudentName = Request.Form["StudentName"];
            obj.StudentStd = Request.Form["StudentStd"];
            obj.StudentDIV = Request.Form["StudentDiv"];
            return View("Student", obj);
        }
    }
}
