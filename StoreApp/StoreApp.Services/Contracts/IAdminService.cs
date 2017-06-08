namespace StoreApp.Services.Contracts
{
    using StoreApp.Models.BindingModels;
    using StoreApp.Models.ViewModels.Admin;
    public interface IAdminService
    {
        AdminPageVm GerAdminPageVm();

        AddProductViewModel GetAddProductVm();

        void AddNewProduct(AddProductBindingModel apbm);
    }
}
