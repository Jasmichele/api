using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyApi.Models;

namespace MyApi.Controllers
{
    public class FoodController : ApiController
    {
        List<Food> food = new List<Food>
        {
            new Food { Id = 1, Name = "Pizza", Cuisine = "Italian", Price = 14.85M },
            new Food { Id = 2, Name = "Taco", Cuisine = "Mexican", Price = 1.25M },
            new Food { Id = 3, Name = "Fries", Cuisine = "French", Price = 2.30M },
            new Food { Id = 4, Name = "Eggroll", Cuisine = "Chinese", Price = .85M },
            new Food { Id = 5, Name = "Greens", Cuisine = "Soul", Price = 14.85M }
        };

        public IEnumerable<Food> GetAllFood()
        {
            return food;
        }

        public IHttpActionResult GetFood(int id)
        {
            var fod = food.SingleOrDefault(f => f.Id == id);

            if(fod == null)
            
                return NotFound();

            return Ok(fod);
        }

        public IHttpActionResult GetByCuisine(string cuis)
        {
            var tFood = food.SingleOrDefault(f => f.Cuisine.ToLower() == cuis.ToLower());

            if (tFood == null)

                return NotFound();

            return Ok(tFood);

        }
    }
}
