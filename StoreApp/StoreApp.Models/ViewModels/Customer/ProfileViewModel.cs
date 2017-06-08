namespace StoreApp.Models.ViewModels.Customer
{
    using System;
    using System.Collections.Generic;
    public class ProfileViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public IEnumerable<CustomerProductsVm> BoughtProducts { get; set; }
    }
}
