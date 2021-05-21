using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        public MoviesController(ILogger<MoviesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        public async Task<IActionResult> ActionMovies()
        {
            return View();
        }

        public async Task<IActionResult> AdventureMovies()
        {
            return View();
        }

        public async Task<IActionResult> ComedyMovies()
        {
            return View();
        }

        public async Task<IActionResult> DramaMovies()
        {
            return View();
        }

        public async Task<IActionResult> HorrorMovies()
        {
            return View();
        }

        public async Task<IActionResult> RomanceMovies()
        {
            return View();
        }

        public async Task<IActionResult> MovieDetails()
        {
            return View();
        }
    }
}
