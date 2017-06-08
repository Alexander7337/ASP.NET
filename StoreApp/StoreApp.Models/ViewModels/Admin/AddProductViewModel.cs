namespace StoreApp.Models.ViewModels.Admin
{
    using System.ComponentModel.DataAnnotations;

    public class AddProductViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
