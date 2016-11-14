using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MyApi.Models
{
    public class Food
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Cuisine { get; set; }

        public decimal Price { get; set; }
    }
}