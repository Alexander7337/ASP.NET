namespace StoreApp.Services
{
    using AutoMapper;
    using Models.ViewModels.Customer;
    using StoreApp.Models.StoreEntities;
    using StoreApp.Models.ViewModels.Admin;
    using System.Collections.Generic;
    using System.Linq;
    using Models.BindingModels;
    using Contracts;
    public class AdminService : Service, IAdminService
    {
        public AdminPageVm GerAdminPageVm()
        {
            AdminPageVm page = new AdminPageVm();
            var products = this.Context.Products.ToList();
            var customers = this.Context.Customers.ToList();

            var productVms = Mapper.Map<IEnumerable<Product>, IEnumerable<CustomerProductsVm>>(products);
            
            IEnumerable<AdminPageUsersVm> userVms = 
                Mapper.Map<IEnumerable<Customer>, IEnumerable<AdminPageUsersVm>>(customers);

            page.Products = productVms;
            page.Users = userVms;
            return page;
        }

        public AddProductViewModel GetAddProductVm()
        {
            AddProductViewModel addProductVm = new AddProductViewModel();
            return addProductVm;
        }

        public void AddNewProduct(AddProductBindingModel apbm)
        {
            Product product = Mapper.Map<AddProductBindingModel, Product>(apbm);
            this.Context.Products.Add(product);
            this.Context.SaveChanges();
        }
    }
}
