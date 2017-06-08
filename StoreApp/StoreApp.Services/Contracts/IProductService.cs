namespace StoreApp.Services.Contracts
{
    using StoreApp.Models.ViewModels.Product;
    public interface IProductService
    {
        ProductViewModel GetDetails(int id);
    }
}
