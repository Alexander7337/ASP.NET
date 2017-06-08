namespace StoreApp.Services
{
    using AutoMapper;
    using StoreApp.Models.StoreEntities;
    using System.Collections.Generic;
    using StoreApp.Models.ViewModels.Product;
    using Contracts;
    public class HomeService : Service, IHomeService
    {
        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            var products = this.Context.Products;
            var productsVms = new List<ProductViewModel>();
            foreach (var product in products)
            {
                var productVm = Mapper.Map<Product, ProductViewModel>(product);
                productsVms.Add(productVm);
            }

            //IEnumerable<ProductViewModel> productVms = Mapper
            //    .Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            return productsVms;
        }
    }
}
