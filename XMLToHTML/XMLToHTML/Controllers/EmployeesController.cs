using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XMLToHTML.Controllers
{
    public class EmployeesController : Controller
    {
        public ActionResult Index()
        {
            string employeesXML = System.IO.File.ReadAllText(Server.MapPath("../XML/Employees.xml"));
            ViewBag.EmployeesXML = employeesXML;
            return View();
        }

    }
}