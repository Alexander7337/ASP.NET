namespace StoreApp.Web.Controllers
{
    using StoreApp.Models.BindingModels;
    using StoreApp.Models.StoreEntities;
    using StoreApp.Models.ViewModels.Customer;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using Services.Contracts;

    [Authorize(Roles = "User")]
    [RoutePrefix("Customer")]
    public class CustomerController : Controller
    {
        private ICustomerService service;

        public CustomerController(ICustomerService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("Buy/{productId}")]
        public ActionResult Buy(int productId)
        {
            string userName = this.User.Identity.Name;
            Customer customer = this.service.GetCurrentCustomer(userName);
            this.service.BuyProduct(productId, customer);
            return this.RedirectToAction("Profile");
        }

        public ActionResult Profile()
        {
            string userId = User.Identity.GetUserId();
            ProfileViewModel profileVm = this.service.GetProfileVm(userId);
            return this.View(profileVm);
        }

        [HttpGet]
        [Route("EditProfile")]
        public ActionResult EditProfile()
        {
            string userName = this.User.Identity.Name;          
            CustomerEditProfileVm cepvm = this.service.GetCustomerEditProfileVm(userName);
            return this.View(cepvm);
        }

        [HttpPost]
        [Route("EditProfile")]
        public ActionResult EditProfile(CustomerEditProfileBm bindingModel)
        {
            string userId = this.User.Identity.GetUserId();

            if (this.ModelState.IsValid)
            {
                this.service.EditCustomerProfile(bindingModel, userId);
                return RedirectToAction("Profile");
            }
          
            CustomerEditProfileVm cepvm = this.service.GetCustomerEditProfileVm(userId);
            return this.View(cepvm);
        }
    }
}