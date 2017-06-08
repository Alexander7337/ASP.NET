using System.ComponentModel.DataAnnotations;

namespace StoreApp.Models.ViewModels.Customer
{
    public class CustomerEditProfileVm
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }
    }
}
