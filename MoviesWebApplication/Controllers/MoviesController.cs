using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MoviesWebApplication.Data;
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

        public async Task<IActionResult> IndexAsync()
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
        public async Task<IActionResult> TopLists()
        {
            return View();
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

        public async Task<IActionResult> MovieDetails()
        {
            return View();
        }
    }
}
