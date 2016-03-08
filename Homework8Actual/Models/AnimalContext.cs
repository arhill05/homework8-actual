using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Homework8Actual.Models
{
    public class AnimalContext : DbContext
    {
        public AnimalContext()
               : base("SQLAzureConnection")
        {

        }
        public DbSet<Animal> Animals { get; set; }

        

    }
}