using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        private readonly UsersContext _usersContext;

        public MoviesController(ILogger<MoviesController> logger, MoviesContext moviesContext, UsersContext userContext)
        {
            _logger = logger;
            _context = moviesContext;
            _usersContext = userContext;
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
                Votes = rating.Votes,
                Toplists = new List<ToplistMovieModel>()
            };

            if (User.Identity.IsAuthenticated && movieDBO != null)
            {
                var toplists = await _usersContext.Toplists.Where(p => p.Email == User.Identity.Name).ToListAsync();
                foreach (var t in toplists)
                {
                    var tm = new ToplistMovieModel
                    {
                        IsSelected = false,
                        ToplistName = t.Name
                    };
                    model.Toplists.Add(tm);
                }
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(IFormCollection form)
        {
            var movieID = int.Parse(form["MovieId"]);

            //foreach()

            //var existing = _usersContext.ToplistMovies.Where(p=>p.MovieId==movieID).FirstOrDefault(p=>p.ToplistId)
           
            //_context.SaveChanges();
            return View();
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
            var l = new List<MoviesModel>();
            var ratings = await _context.Ratings.Where(p => p.Rating > 8).OrderByDescending(p => p.Rating).ToListAsync();
            for(int i=0;i<10;i++)
            {
                var movie = await _context.Movies.FirstOrDefaultAsync(p => p.Id == ratings[i].MovieId);
                MoviesModel model = new MoviesModel
                {
                    Id = movie.Id,
                    Name = movie.Title,
                    Rating = (int)ratings[i].Rating,
                    Votes = ratings[i].Votes,
                };
                l.Add(model);
            }

            return View(l);
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
