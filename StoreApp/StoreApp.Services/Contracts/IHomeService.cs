namespace StoreApp.Services.Contracts
{
    using StoreApp.Models.ViewModels.Product;
    using System.Collections.Generic;

    public interface IHomeService
    {
        IEnumerable<ProductViewModel> GetAllProducts();
    }
}
