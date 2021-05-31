using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesWebApplication.Data;
using MoviesWebApplication.Data.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MoviesWebApplication.Controllers
{
    public class StarController : Controller
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly MoviesContext _context;

        public StarController(ILogger<MoviesController> logger, MoviesContext moviesContext)
        {
            _logger = logger;
            _context = moviesContext;
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return null;
            }
            
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return null;
            }

            ViewBag.MovieId = id.Value;

            var rating = _context.Ratings.FirstOrDefault(p =>p.MovieId==id.Value);
            if (rating != null)
            {
                var ratingSum = rating.Rating;
                ViewBag.RatingSum = ratingSum;
                var ratingCount = rating.Votes;
                ViewBag.RatingCount = ratingCount;
            }
            else
            {
                ViewBag.RatingSum = 0;
                ViewBag.RatingCount = 0;
            }

            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(IFormCollection form)
        {
            var movieID = int.Parse(form["MovieId"]);
            var rating = int.Parse(form["Rating"]);

            var originalRate = _context.Ratings.FirstOrDefault(p => p.MovieId == movieID);
            var movie = _context.Movies.FirstOrDefault(p => p.Id == movieID);

            var rate = new RatingDBO
            {
                MovieId = movieID,
                Movie = movie,
                Rating = rating,
                Votes = 1
            };

            if (originalRate != null)
            {
                var oldScore = originalRate.Rating;
                var newVotes = originalRate.Votes + 1;
                var newScore = (oldScore * (newVotes - 1) + rating) / newVotes;

                rate.Rating = newScore;
                rate.Votes = newVotes;
                rate.Id = originalRate.Id;

                _context.Remove(originalRate);
            }

            _context.Ratings.Add(rate);
            _context.SaveChanges();

            return RedirectToAction("Details", "Movies", new { id = movie.Title });
        }
    }
}
