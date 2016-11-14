using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using First_Api.Models;

namespace First_Api.Controllers
{
    public class SportsController : Controller
    {
        // GET: Sports
        Sports[] sports = new Sports[]
        {
            new Sports { Id = 1, Name = "Swimming", Seasons = "Summer" },
            new Sports { Id = 2, Name = "VolleyBall", Seasons = "Summer"},
            new Sports { Id = 3, Name = "Snow Boarding", Seasons = "Winter"},
            new Sports { Id = 4, Name = "Football", Seasons = "Fall"}
        };

        public IEnumerable<Sports> GetAllProducts()
        {
            return products;
        }

    }
}