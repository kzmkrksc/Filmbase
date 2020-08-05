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

            var customers = new List<Customer>
            {
            new Customer{Name="Carson Alexander",IsSubscribedToNewsletter=false,MembershipTypeId=1,BirthDate=new DateTime(1989,11,11)},
            new Customer{Name="Meredith Alonso",IsSubscribedToNewsletter=true,MembershipTypeId=2,BirthDate=new DateTime(1969,1,1)},
            new Customer{Name="Arturo Anand",IsSubscribedToNewsletter=false,MembershipTypeId=3,BirthDate=new DateTime(1959,2,2)},
            new Customer{Name="Gytis Barzdukas",IsSubscribedToNewsletter=true,MembershipTypeId=4,BirthDate=new DateTime(1939,3,3)},
            new Customer{Name="Yan Li",IsSubscribedToNewsletter=false,MembershipTypeId=1,BirthDate=new DateTime(1988,11,21)},
            new Customer{Name="Peggy Justice",IsSubscribedToNewsletter=true,MembershipTypeId=2,BirthDate=new DateTime(1985,6,14)},
            new Customer{Name="Laura Norman",IsSubscribedToNewsletter=false,MembershipTypeId=3,BirthDate=new DateTime(1984,7,16)},
            new Customer{Name="Nino Olivetto",IsSubscribedToNewsletter=true,MembershipTypeId=4,BirthDate=new DateTime(1982,8,1)}
            };
            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
        }
    }
}
