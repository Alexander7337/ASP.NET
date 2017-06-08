namespace StoreApp.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models.StoreEntities;
    using System;
    using System.Data.Entity;

    public class StoreAppContext : IdentityDbContext<ApplicationUser>
    {
        public StoreAppContext()
            : base("name=StoreAppContext", throwIfV1Schema: false)
        {
            // Database.SetInitializer(new MigrateDatabaseToLatestVersion<TechZoneContext, Configuration>());
        }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Product> Products { get; set; }
        

        public static StoreAppContext Create()
        {
            return new StoreAppContext();
        } 
    }
}