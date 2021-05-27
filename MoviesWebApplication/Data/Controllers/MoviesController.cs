using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesWebApplication.Data;

namespace MoviesWebApplication.Data.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MoviesContext _context;

        public MoviesController(MoviesContext context)
        {
            _context = context;
        }

        //// GET: Movies
        //public async Task<IActionResult> Index()
        //{
        //    var list = await _context.Movies.ToListAsync();
        //    var r = new Random();
        //    var l = new List<MovieDBO>();
        //    int i = 0;
        //    while (i <= 15)
        //    {
        //        l.Add(list.ElementAt(r.Next(0, list.Count())));
        //        i++;
        //    }
        //    return View(l);
        //}

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieDBO = await _context.Movies
                .FirstOrDefaultAsync(m => m.Title == id);
            if (movieDBO == null)
            {
                return NotFound();
            }

            return View(movieDBO);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Year")] MovieDBO movieDBO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movieDBO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movieDBO);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieDBO = await _context.Movies.FindAsync(id);
            if (movieDBO == null)
            {
                return NotFound();
            }
            return View(movieDBO);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Year")] MovieDBO movieDBO)
        {
            if (id != movieDBO.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movieDBO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieDBOExists(movieDBO.Id))
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
            return View(movieDBO);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieDBO = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movieDBO == null)
            {
                return NotFound();
            }

            return View(movieDBO);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieDBO = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movieDBO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieDBOExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}
