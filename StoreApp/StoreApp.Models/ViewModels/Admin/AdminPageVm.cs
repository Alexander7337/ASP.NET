namespace StoreApp.Models.ViewModels.Admin
{
    using StoreApp.Models.ViewModels.Customer;
    using System.Collections.Generic;
    public class AdminPageVm
    {
        public IEnumerable<CustomerProductsVm> Products { get; set; }

        public IEnumerable<AdminPageUsersVm> Users { get; set; }
    }
}
