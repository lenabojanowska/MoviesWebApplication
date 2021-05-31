using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesWebApplication.Data;
using MoviesWebApplication.Data.DBO;

namespace MoviesWebApplication.Controllers
{
    public class ToplistsController : Controller
    {
        private readonly UsersContext _context;

        public ToplistsController(UsersContext context)
        {
            _context = context;
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

            var toplistDBO = await _context.Toplists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (toplistDBO == null)
            {
                return NotFound();
            }

            return View(toplistDBO);
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

        public async Task<IActionResult> RemoveMovie(int? id, int? movieId)
        {
            if (id == null || movieId==null)
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
                var movie = toplistDBO.Movies.FirstOrDefault(p => p.Id == movieId);
                if (movie != null)
                {
                    toplistDBO.Movies.Remove(movie);
                    _context.Update(toplistDBO);
                    await _context.SaveChangesAsync();
                }
            }

            return View(toplistDBO);
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
