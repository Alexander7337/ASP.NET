namespace MoviesStoreApp.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MoviesStoreApp.Models.MoviesStoreAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MoviesStoreApp.Models.MoviesStoreAppContext context)
        {
            context.Movies.AddOrUpdate(
                        x => x.Title,
                        new Movie() { Title = "Maximum Payback", Director = "David D.", ReleaseDate = new DateTime(1997, 1, 18), Genre = "Action", Rating = "PG-13" },
                        new Movie() { Title = "Inferno of Retribution", Director = "Tarantino", ReleaseDate = new DateTime(1994, 2, 2), Genre = "Action", Rating = "PG" },
                        new Movie() { Title = "Fatal Vengeance 2", Director = "Scorsese", ReleaseDate = new DateTime(1993, 7, 22), Genre = "Action", Rating = "PG-13" },
                        new Movie() { Title = "Sudden Danger", Director = "Bruckheimer", ReleaseDate = new DateTime(1991, 4, 1), Genre = "Action", Rating = "PG-13" },
                        new Movie() { Title = "Forgotten Doors", ReleaseDate = new DateTime(2001, 8, 5), Genre = "Drama", Rating = "R" },
                        new Movie() { Title = "Blue Moon June", ReleaseDate = new DateTime(1994, 1, 18), Genre = "Drama", Rating = "PG-13" },
                        new Movie() { Title = "The Edge of the Sun", ReleaseDate = new DateTime(1991, 1, 18), Genre = "Drama", Rating = "PG-13" },
                        new Movie() { Title = "The Nameless Sword", ReleaseDate = new DateTime(1992, 5, 5), Genre = "Fantasy", Rating = "PG" },
                        new Movie() { Title = "Guardian of the Vanished Mountain", ReleaseDate = new DateTime(1995, 1, 5), Genre = "Fantasy", Rating = "G" },
                        new Movie() { Title = "The Nameless Sword II: Skull Valley", ReleaseDate = new DateTime(1992, 1, 4), Genre = "Fantasy", Rating = "PG-13" },
                        new Movie() { Title = "Nightmare Zombie", ReleaseDate = new DateTime(1997, 1, 1), Genre = "Horror", Rating = "R" },
                        new Movie() { Title = "Zombie Spider Queen", ReleaseDate = new DateTime(1998, 2, 1), Genre = "Horror", Rating = "PG" },
                        new Movie() { Title = "Mutant Darkness", ReleaseDate = new DateTime(1999, 3, 4), Genre = "Horror", Rating = "R" },
                         new Movie() { Title = "Nightmare Zombie", ReleaseDate = new DateTime(1997, 1, 1), Genre = "Horror", Rating = "R" },
                        new Movie() { Title = "Zombie Spider Queen", ReleaseDate = new DateTime(1998, 2, 1), Genre = "Horror", Rating = "PG" },
                        new Movie() { Title = "Mutant Darkness", ReleaseDate = new DateTime(1999, 3, 4), Genre = "Horror", Rating = "R" }
           );
        }
    }
}
