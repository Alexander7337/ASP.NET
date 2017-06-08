namespace StoreApp.Web.Controllers
{
    using Services.Contracts;
    using StoreApp.Models.ViewModels.Product;
    using StoreApp.Web.Attributes;
    using System.Collections.Generic;
    using System.Web.Mvc;

    [CustomAuthorization(Roles = "User")]
    public class HomeController : Controller
    {
        public IHomeService service;

        public HomeController(IHomeService service)
        {
            this.service = service;
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            IEnumerable<ProductViewModel> productVms = this.service.GetAllProducts();
            return View(productVms);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}