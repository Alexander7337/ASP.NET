namespace StoreApp.Web.Areas.Admin.Controllers
{
    using Models.BindingModels;
    using Models.ViewModels.Admin;
    using Services.Contracts;
    using System.Web.Mvc;

    [Authorize(Roles = "Admin")]
    [RouteArea("Administration")]

    public class AdminController : Controller
    {
        private IAdminService service;

        public AdminController(IAdminService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("Panel")]
        public ActionResult Panel()
        {
            AdminPageVm vm = this.service.GerAdminPageVm();
            return this.View(vm);
        }

        [HttpGet]
        [Route("AddProduct")]
        public ActionResult AddProduct()
        {
            AddProductViewModel addProductVm = this.service.GetAddProductVm();
            return this.View(addProductVm);
        }

        [HttpPost]
        [Route("AddProduct")]
        public ActionResult AddProduct(AddProductBindingModel apbm)
        {
            if (ModelState.IsValid)
            {
                this.service.AddNewProduct(apbm);
                return RedirectToAction("Panel", "Admin", new { area = "Admin" });
            }

            AddProductViewModel addProductVm = this.service.GetAddProductVm();
            return this.View(addProductVm);
        }

        [HttpGet]
        [Route("EditProduct/Edit/{id}")]
        public ActionResult EditProduct(int id)
        {
            return this.View();
        }

        [HttpGet]
        [Route("EditUser/Edit/{id}")]
        public ActionResult EditUser(int id)
        {
            return this.View();
        }
    }
}