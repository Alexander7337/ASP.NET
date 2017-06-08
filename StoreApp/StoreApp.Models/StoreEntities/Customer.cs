namespace StoreApp.Models.StoreEntities
{
    using System;
    using System.Collections.Generic;

    public class Customer
    {
        public Customer()
        {
            this.Products = new HashSet<Product>();
        }
        public int Id { get; set; }

        public DateTime? BirthDate { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
