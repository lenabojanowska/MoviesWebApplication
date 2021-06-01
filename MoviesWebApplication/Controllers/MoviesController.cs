using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MoviesWebApplication.Data;
using MoviesWebApplication.Data.DBO;
using MoviesWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApplication.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly MoviesContext _context;

        public MoviesController(ILogger<MoviesController> logger, MoviesContext moviesContext)
        {
            _logger = logger;
            _context = moviesContext;
        }
      
        public ActionResult Search(string searching)
        {
            return View(_context.Movies.Where(x => x.Title.Contains(searching) || searching == null).ToList());
        }
        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            var list = await _context.Movies.ToListAsync();
            var r = new Random();
            var l = new List<MovieDBO>();
            if (list.Count() > 0)
            {
                int i = 0;
                while (i <= 11)
                {
                    l.Add(list.ElementAt(r.Next(0, list.Count())));
                    i++;
                }
            }

            return View(l);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Authorize]
        public async Task<IActionResult> TopList()
        {
            var list = await _context.Movies.ToListAsync();
            var r = new Random();
            var l = new List<MovieDBO>();
            if (list.Count() > 0)
            {
                int i = 0;
                while (i <= 9)
                {
                    l.Add(list.ElementAt(r.Next(0, list.Count())));
                    i++;
                }
            }

            return View(l);
        }

        [Authorize]
        public async Task<IActionResult> ActionMoviesAsync()
        {
            var list = await _context.Movies.ToListAsync();
            var r = new Random();
            var l = new List<MovieDBO>();
            if (list.Count() > 0)
            {
                int i = 0;
                while (i <= 199)
                {
                    l.Add(list.ElementAt(r.Next(0, list.Count())));
                    i++;
                }
            }

            return View(l);
          
        }

        public async Task<IActionResult> AdventureMovies()
        {
            var list = await _context.Movies.ToListAsync();
            var r = new Random();
            var l = new List<MovieDBO>();
            if (list.Count() > 0)
            {
                int i = 0;
                while (i <= 79)
                {
                    l.Add(list.ElementAt(r.Next(0, list.Count())));
                    i++;
                }
            }

            return View(l);
        }

        public async Task<IActionResult> ComedyMovies()
        {
            var list = await _context.Movies.ToListAsync();
            var r = new Random();
            var l = new List<MovieDBO>();
            if (list.Count() > 0)
            {
                int i = 0;
                while (i <= 79)
                {
                    l.Add(list.ElementAt(r.Next(0, list.Count())));
                    i++;
                }
            }

            return View(l);
        }

        public async Task<IActionResult> DramaMovies()
        {
            var list = await _context.Movies.ToListAsync();
            var r = new Random();
            var l = new List<MovieDBO>();
            if (list.Count() > 0)
            {
                int i = 0;
                while (i <= 79)
                {
                    l.Add(list.ElementAt(r.Next(0, list.Count())));
                    i++;
                }
            }

            return View(l);
        }

        public async Task<IActionResult> HorrorMovies()
        {
            var list = await _context.Movies.ToListAsync();
            var r = new Random();
            var l = new List<MovieDBO>();
            if (list.Count() > 0)
            {
                int i = 0;
                while (i <= 79)
                {
                    l.Add(list.ElementAt(r.Next(0, list.Count())));
                    i++;
                }
            }

            return View(l);
        }

        public async Task<IActionResult> RomanceMovies()
        {
            var list = await _context.Movies.ToListAsync();
            var r = new Random();
            var l = new List<MovieDBO>();
            if (list.Count() > 0)
            {
                int i = 0;
                while (i <= 79)
                {
                    l.Add(list.ElementAt(r.Next(0, list.Count())));
                    i++;
                }
            }

            return View(l);
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieDBO = await _context.Movies.FirstOrDefaultAsync(m => m.Title == id);
            if (movieDBO == null)
            {
                return NotFound();
            }

            var rating = await _context.Ratings.FirstOrDefaultAsync(m => m.MovieId == movieDBO.Id);
            if (rating == null)
            {
                rating = new RatingDBO();
                rating.Rating = 0;
                rating.Votes = 0;
            }

            MoviesModel model = new MoviesModel
            {
                Id = movieDBO.Id,
                Name = movieDBO.Title,
                Rating = (int)rating.Rating,
                Votes = rating.Votes
            };

            return View(model);
        }

        public async Task<IActionResult> Upcoming()
        {
            return View();
        }
        public async Task<IActionResult> TopRatedAPI()
        {
            return View();
        }

        public async Task<IActionResult> Popular()
        {
            return View();
        }

        public async Task<IActionResult> Statistics()
        {
            return View();
        }

        public async Task<IActionResult> MovieDetails()
        {
            return View();
        }

    }
}
