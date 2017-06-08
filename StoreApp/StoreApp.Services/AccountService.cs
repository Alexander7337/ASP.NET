namespace StoreApp.Services
{
    using Contracts;
    using StoreApp.Models.StoreEntities;

    public class AccountService : Service, IAccountService
    {
        public void CreateCustomer(ApplicationUser user)
        {
            Customer customer = new Customer();
            ApplicationUser currentUser = this.Context.Users.Find(user.Id);
            customer.User = currentUser;
            this.Context.Customers.Add(customer);
            this.Context.SaveChanges();
        }
    }
}
