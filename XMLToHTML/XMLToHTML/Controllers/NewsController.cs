using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace XMLToHTML.Controllers
{
    public class NewsController : Controller
    {
        private const string _url = @"http://www.investor.bg/news/rss/top/";
        // GET: News
        public ActionResult Index()
        {
            string data = string.Empty;
            
            using (WebClient client = new WebClient())
            {
                byte[] bytes = Encoding.Default.GetBytes(client.DownloadString(_url));
                data = Encoding.UTF8.GetString(bytes);
            }

            //Console.WriteLine(data);

            ViewBag.Data = data;

            return View();
        }


    }
}