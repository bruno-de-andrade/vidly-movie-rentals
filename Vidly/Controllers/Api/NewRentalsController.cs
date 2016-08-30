using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalsDto newRental)
        {
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id));

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                _context.Rentals.Add(new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                });

                movie.NumberAvailable--;
            }
            
            _context.SaveChanges();

            return Ok();
        }
    }
}
