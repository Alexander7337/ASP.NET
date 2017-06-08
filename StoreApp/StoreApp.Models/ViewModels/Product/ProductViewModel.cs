namespace StoreApp.Models.ViewModels.Product
{
    using System.ComponentModel.DataAnnotations;

    public class ProductViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Brand")]
        public string Name { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
    }
}
