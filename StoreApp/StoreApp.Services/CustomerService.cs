namespace StoreApp.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using StoreApp.Models.StoreEntities;
    using StoreApp.Models.ViewModels.Customer;
    using AutoMapper;
    using Models.BindingModels;
    using Contracts;
    public class CustomerService : Service, ICustomerService
    {
        public Customer GetCurrentCustomer(string userName)
        {
            ApplicationUser user = this.Context
                .Users.FirstOrDefault(appUser => appUser.UserName == userName);
            Customer currentCustomer = this.Context
                .Customers.FirstOrDefault(c => c.User.Id == user.Id);
            return currentCustomer;
        }

        public void BuyProduct(int productId, Customer customer)
        {
            Product product = this.Context.Products.Find(productId);
            customer.Products.Add(product);
            this.Context.SaveChanges();
        }

        public ProfileViewModel GetProfileVm(string userId)
        {
            ApplicationUser currentUser = 
                this.Context.Users.FirstOrDefault(u => u.Id == userId);
            ProfileViewModel pvm = Mapper
                .Map<ApplicationUser, ProfileViewModel>(currentUser);
            Customer customer = 
                this.Context.Customers.FirstOrDefault(c => c.User.Id == currentUser.Id);
            pvm.BoughtProducts = Mapper
                .Map<IEnumerable<Product>, IEnumerable<CustomerProductsVm>>(customer.Products);
            return pvm;
        }

        public CustomerEditProfileVm GetCustomerEditProfileVm(string userName)
        {
            ApplicationUser currentUser =
                this.Context.Users.FirstOrDefault(u => u.Name == userName);
            CustomerEditProfileVm cepvm = Mapper.Map<ApplicationUser, CustomerEditProfileVm>(currentUser);
            return cepvm;
        }

        public void EditCustomerProfile(CustomerEditProfileBm bindingModel, string userId)
        {
            ApplicationUser currentUser = 
                this.Context.Users.FirstOrDefault(u => u.Id == userId);
            currentUser.Name = bindingModel.Name;
            currentUser.UserName = bindingModel.UserName;
            this.Context.SaveChanges();
        }
    }
}
