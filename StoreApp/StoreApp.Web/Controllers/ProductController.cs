namespace StoreApp.Web.Controllers
{
    using Services.Contracts;
    using StoreApp.Models.ViewModels.Product;
    using System.Web.Mvc;

    //[Authorize(Roles = "")]
    [RoutePrefix("Product")]
    public class ProductController : Controller
    {
        private IProductService service;

        public ProductController(IProductService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("Details/{id}")]
        [AllowAnonymous]
        public ActionResult Details(int id = 1)
        {
            ProductViewModel productVm = this.service.GetDetails(id);

            if (productVm == null)
            {
                return HttpNotFound();
            }

            return this.View(productVm);
        }
    }
}