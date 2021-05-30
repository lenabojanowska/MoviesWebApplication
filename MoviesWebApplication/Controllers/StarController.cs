using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesWebApplication.Data;
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

            //var comments = db.ArticlesComments.Where(d => d.ArticleId.Equals(id.Value)).ToList();
            //ViewBag.Comments = comments;

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
    }
}
