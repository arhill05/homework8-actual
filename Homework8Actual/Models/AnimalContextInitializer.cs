using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Homework8Actual.Models
{
    public class AnimalContextInitializer : DropCreateDatabaseIfModelChanges<AnimalContext>
    {
        protected override void Seed(AnimalContext context)
        {
            context.Animals.Add(
                new Animal()
                {
                    Name = "Fido",
                    Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    DateReceieved = new DateTime(2016, 3, 7),
                    Image = "./",
                    Price = 10.00M,
                    Quantity = 1
                });
            context.Animals.Add(
                new Animal() { Name = "Otis", Description = "German Shepherd", DateReceieved = new DateTime(2016, 3, 7), Image = "./", Price = 10.00M, Quantity = 1 }
            );
            context.Animals.Add(
                new Animal() { Name = "Rufus", Description = "Dauchsund", DateReceieved = new DateTime(2016, 3, 7), Image = "./", Price = 10.00M, Quantity = 1 }
            );
            context.SaveChanges();
        }
    }
}