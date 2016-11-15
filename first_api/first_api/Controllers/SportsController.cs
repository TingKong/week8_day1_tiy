using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using First_Api.Models;

namespace First_Api.Controllers
{
    public class SportsController : ApiController
    {
        // GET: Sports
        List<Sports> sports = new List<Sports>

        {
            new Sports { Id = 1, Name = "Swimming", Seasons = "Summer", Players = 1 },
            new Sports { Id = 2, Name = "VolleyBall", Seasons = "Spring", Players = 6},
            new Sports { Id = 3, Name = "Snow Boarding", Seasons = "Winter", Players = 1},
            new Sports { Id = 4, Name = "Football", Seasons = "Fall", Players = 11}
        };

        public IEnumerable<Sports> GetAllSports()
        {
            return sports;
        }
        //IEnumerable<Sports> 
        public IHttpActionResult  GetSports(int id)
        {
          
            var sport = sports.SingleOrDefault(p => p.Id == id);

            if (sport == null)
                return NotFound();

            return Ok(sport);
        }


        public IHttpActionResult GetSportBySeason(string season)
        {
            //var product = from p in products
            //              where p.Category.ToLower() == cat.ToLower();
            //select p;
            var sport = sports.SingleOrDefault(p => p.Seasons.ToLower() == season.ToLower());

            if (sport == null)
                return NotFound();

            return Ok(sport);
        }

        public IEnumerable<Sports> GetoList(int id, string sportse, string season, int players)
        {
            new Sports { Id = 1, Name = "Swimming", Seasons = "Summer", Players = 1 };

            Sports newSports = new Models.Sports();
            newSports.Id = id;
            newSports.Name = sportse;
            newSports.Seasons = season;
            newSports.Players = players;

            sports.Add(newSports);

            return sports;
        }


    }
}