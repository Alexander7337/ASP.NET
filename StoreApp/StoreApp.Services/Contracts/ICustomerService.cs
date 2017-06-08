namespace StoreApp.Services.Contracts
{
    using StoreApp.Models.BindingModels;
    using StoreApp.Models.StoreEntities;
    using StoreApp.Models.ViewModels.Customer;
    public interface ICustomerService
    {
        Customer GetCurrentCustomer(string userName);
        void BuyProduct(int productId, Customer customer);
        ProfileViewModel GetProfileVm(string userId);
        CustomerEditProfileVm GetCustomerEditProfileVm(string userName);
        void EditCustomerProfile(CustomerEditProfileBm bindingModel, string userId);
    }
}
