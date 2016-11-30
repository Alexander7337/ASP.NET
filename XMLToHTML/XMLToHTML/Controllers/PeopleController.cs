using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using XMLToHTML.Models;

namespace XMLToHTML.Controllers
{
    public class PeopleController : Controller
    {
        private const string personsPath = @"C:\Users\aleksander.y\Documents\Visual Studio 2015\Projects\XMLToHTML\XMLToHTML\JSON\persons.json";
        // GET: People
        public ActionResult Index()
        {
            var json = System.IO.File.ReadAllText(personsPath);

            var people = JsonConvert.DeserializeObject<IEnumerable<PersonDTO>>(json);

            XDocument xml = new XDocument();


            foreach (var person in people)
            {
            }

            ViewBag.Xml = xml;
            return View();
        }
    }
}