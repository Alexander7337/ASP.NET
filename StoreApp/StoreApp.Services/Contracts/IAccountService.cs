namespace StoreApp.Services.Contracts
{
    using StoreApp.Models.StoreEntities;
    public interface IAccountService
    {
        void CreateCustomer(ApplicationUser user);
    }
}
