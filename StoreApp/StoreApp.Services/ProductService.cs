namespace StoreApp.Services
{
    using AutoMapper;
    using Contracts;
    using StoreApp.Models.StoreEntities;
    using StoreApp.Models.ViewModels.Product;

    public class ProductService : Service, IProductService
    {
        public ProductViewModel GetDetails(int id)
        {
            Product product = this.Context.Products.Find(id);

            if (product == null)
            {
                return null;
            }

            ProductViewModel pvm = Mapper.Map<Product, ProductViewModel>(product);

            return pvm;
        }
    }
}
