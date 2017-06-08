namespace StoreApp.Models.StoreEntities
{
    using System.Collections.Generic;

    public class Product
    {
        public Product()
        {
            this.Customers = new HashSet<Customer>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
