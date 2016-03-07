using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework8Actual.Models
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime DateReceieved { get; set; }
    }
}