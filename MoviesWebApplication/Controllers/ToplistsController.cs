using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesWebApplication.Data;
using MoviesWebApplication.Data.DBO;
using MoviesWebApplication.Models;

namespace MoviesWebApplication.Controllers
{
    public class ToplistsController : Controller
    {
        private readonly UsersContext _context;
        private readonly MoviesContext _mcontext;

        public ToplistsController(UsersContext context, MoviesContext moviesContext)
        {
            _context = context;
            _mcontext = moviesContext;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var list = await _context.Toplists.Where(p => p.Email == User.Identity.Name).ToListAsync();
            return View(list);
        }

        // GET: Toplists/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var result = new ToplistModel{};

            var toplistDBO = await _context.Toplists.FirstOrDefaultAsync(m => m.Id == id);
            if (toplistDBO == null)
            {
                return NotFound();
            }
            else
            {
                result.Id = toplistDBO.Id;
                result.Name = toplistDBO.Name;
                result.IsPublic = toplistDBO.IsPublic;
                var l = _context.ToplistMovies.Where(p => p.ToplistId == toplistDBO.Id);
                foreach (var el in l)
                {
                    var m = await _mcontext.Movies.FirstOrDefaultAsync(p => p.Id == el.MovieId);
                    if (m != null)
                        result.Movies.Add(m);
                }
            }

            return View(result);
        }

        // GET: Toplists/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Toplists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,IsPublic,Email")] ToplistDBO toplistDBO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(toplistDBO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(toplistDBO);
        }

        // GET: Toplists/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toplistDBO = await _context.Toplists.FindAsync(id);
            if (toplistDBO == null)
            {
                return NotFound();
            }
            return View(toplistDBO);
        }

        // POST: Toplists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,IsPublic")] ToplistDBO toplistDBO)
        {
            if (id != toplistDBO.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(toplistDBO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToplistDBOExists(toplistDBO.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(toplistDBO);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveMovie(IFormCollection form)
        {
            var movieId = int.Parse(form["MovieId"]);
            var id = int.Parse(form["ToplistId"]);

            if (id == 0 || movieId==0)
            {
                return NotFound();
            }

            var toplistDBO = await _context.Toplists.FirstOrDefaultAsync(m => m.Id == id);
            if (toplistDBO == null)
            {
                return NotFound();
            }
            else
            {
                var movie = _context.ToplistMovies.FirstOrDefault(p => p.MovieId == movieId);
                if (movie != null)
                {
                    _context.Remove(movie);
                    await _context.SaveChangesAsync();
                }
            }

            return RedirectToAction("Details", "Toplists", new { id = id });
        }

        // GET: Toplists/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toplistDBO = await _context.Toplists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (toplistDBO == null)
            {
                return NotFound();
            }

            return View(toplistDBO);
        }

        // POST: Toplists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var toplistDBO = await _context.Toplists.FindAsync(id);
            _context.Toplists.Remove(toplistDBO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ToplistDBOExists(int id)
        {
            return _context.Toplists.Any(e => e.Id == id);
        }
    }
}
