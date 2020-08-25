namespace FilmBase.Migrations
{
    using FilmBase.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FilmBase.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FilmBase.Models.ApplicationDbContext";
        }

        protected override void Seed(FilmBase.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            context.Customers.AddOrUpdate(
                c => new { c.Name, c.BirthDate },
                new Customer { Name = "Ahmet Okay", IsSubscribedToNewsletter = false, MembershipTypeId = 1, BirthDate = new DateTime(1988, 1, 18) },
                new Customer { Name = "Muhtar Kent", IsSubscribedToNewsletter = true, MembershipTypeId = 2, BirthDate = new DateTime(1978, 2, 27) },
                new Customer { Name = "Pekgüzel Tavasapý", IsSubscribedToNewsletter = true, MembershipTypeId = 3, BirthDate = new DateTime(1968, 3, 16) },
                new Customer { Name = "Þehriye Pilav", IsSubscribedToNewsletter = true, MembershipTypeId = 4, BirthDate = new DateTime(1958, 4, 15) },
                new Customer { Name = "Muhlis Dünyadagülmez", IsSubscribedToNewsletter = true, MembershipTypeId = 3, BirthDate = new DateTime(1986, 5, 14) },
                new Customer { Name = "Makbule Killibaldir", IsSubscribedToNewsletter = true, MembershipTypeId = 2, BirthDate = new DateTime(1985, 6, 13) },
                new Customer { Name = "Döndü Yuvarlak", IsSubscribedToNewsletter = true, MembershipTypeId = 2, BirthDate = new DateTime(1984, 7, 12) },
                new Customer { Name = "Mümin Göbek", IsSubscribedToNewsletter = false, MembershipTypeId = 1, BirthDate = new DateTime(1983, 8, 11) },
                new Customer { Name = "Carson Alexander", IsSubscribedToNewsletter = false, MembershipTypeId = 1, BirthDate = new DateTime(1989, 11, 11) },
                new Customer { Name = "Meredith Alonso", IsSubscribedToNewsletter = true, MembershipTypeId = 2, BirthDate = new DateTime(1969, 1, 1) },
                new Customer { Name = "Arturo Anand", IsSubscribedToNewsletter = false, MembershipTypeId = 3, BirthDate = new DateTime(1959, 2, 2) },
                new Customer { Name = "Gytis Barzdukas", IsSubscribedToNewsletter = true, MembershipTypeId = 4, BirthDate = new DateTime(1939, 3, 3) },
                new Customer { Name = "Yan Li", IsSubscribedToNewsletter = false, MembershipTypeId = 1, BirthDate = new DateTime(1988, 11, 21) },
                new Customer { Name = "Peggy Justice", IsSubscribedToNewsletter = true, MembershipTypeId = 2, BirthDate = new DateTime(1985, 6, 14) },
                new Customer { Name = "Laura Norman", IsSubscribedToNewsletter = false, MembershipTypeId = 3, BirthDate = new DateTime(1984, 7, 16) },
                new Customer { Name = "Nino Olivetto", IsSubscribedToNewsletter = true, MembershipTypeId = 4, BirthDate = new DateTime(1982, 8, 1) },
                new Customer { Name = "John Doe", IsSubscribedToNewsletter = true, MembershipTypeId = 2, BirthDate = new DateTime(1980, 8, 8) }
                );

            context.Movies.AddOrUpdate(
                m => new { m.Name, m.ReleaseDate },
                new Movie { Id = 1, Name = "Fast and Furious", ReleaseDate=new DateTime(2001,1,1) },
                new Movie { Id = 2, Name = "Lord of the Rings: The Fellowship of the Ring", ReleaseDate = new DateTime(2001, 1, 1) },
                new Movie { Id = 3, Name = "Gladiator", ReleaseDate = new DateTime(2000, 1, 1) },
                new Movie { Id = 4, Name = "Inception", ReleaseDate = new DateTime(2010, 1, 1) },
                new Movie { Id = 5, Name = "Prestige", ReleaseDate = new DateTime(2006, 1, 1) },
                new Movie { Id = 6, Name = "Illusionist", ReleaseDate = new DateTime(2006, 1, 1) },
                new Movie { Id = 7, Name = "Midnight in Paris", ReleaseDate = new DateTime(2011, 1, 1) },
                new Movie { Id = 8, Name = "Avengers: Endgame", ReleaseDate = new DateTime(2019, 1, 1) },
                new Movie { Id = 9, Name = "Braveheart", ReleaseDate = new DateTime(1995, 1, 1) },
                new Movie { Id = 10, Name = "Inglourious Basterds", ReleaseDate = new DateTime(2009, 1, 1) },
                new Movie { Id = 11, Name = "Django", ReleaseDate = new DateTime(2012, 1, 1) },
                new Movie { Id = 12, Name = "Hateful Eight", ReleaseDate = new DateTime(2015, 1, 1) },
                new Movie { Id = 13, Name = "Kill Bill: Vol I", ReleaseDate = new DateTime(2003, 1, 1) }
                );
            //var customers = new List<Customer>
            //{
            //new Customer{Name="Carson Alexander",IsSubscribedToNewsletter=false,MembershipTypeId=1,BirthDate=new DateTime(1989,11,11)},
            //new Customer{Name="Meredith Alonso",IsSubscribedToNewsletter=true,MembershipTypeId=2,BirthDate=new DateTime(1969,1,1)},
            //new Customer{Name="Arturo Anand",IsSubscribedToNewsletter=false,MembershipTypeId=3,BirthDate=new DateTime(1959,2,2)},
            //new Customer{Name="Gytis Barzdukas",IsSubscribedToNewsletter=true,MembershipTypeId=4,BirthDate=new DateTime(1939,3,3)},
            //new Customer{Name="Yan Li",IsSubscribedToNewsletter=false,MembershipTypeId=1,BirthDate=new DateTime(1988,11,21)},
            //new Customer{Name="Peggy Justice",IsSubscribedToNewsletter=true,MembershipTypeId=2,BirthDate=new DateTime(1985,6,14)},
            //new Customer{Name="Laura Norman",IsSubscribedToNewsletter=false,MembershipTypeId=3,BirthDate=new DateTime(1984,7,16)},
            //new Customer{Name="Nino Olivetto",IsSubscribedToNewsletter=true,MembershipTypeId=4,BirthDate=new DateTime(1982,8,1)}
            //};
            //customers.ForEach(s => context.Customers.Add(s));
            //context.SaveChanges();
        }
    }
}
