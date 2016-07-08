using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstProject.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       
    }
}