using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesWebApplication.Data;
using MoviesWebApplication.Data.DBO;

namespace MoviesWebApplication.Data.Controllers
{
    public class PeopleController : Controller
    {
        private readonly MoviesContext _context;

        public PeopleController(MoviesContext context)
        {
            _context = context;
        }

        // GET: People
        public async Task<IActionResult> Index()
        {
            var list = await _context.People.ToListAsync();
            var r = new Random();
            var l = new List<PersonDBO>();
            if (list.Count() > 0)
            {
                int i = 0;
                while (i <= 15)
                {
                    l.Add(list.ElementAt(r.Next(0, list.Count())));
                    i++;
                }
            }

            return View(l);
        }

        // GET: People/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personDBO = await _context.People
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personDBO == null)
            {
                return NotFound();
            }

            return View(personDBO);
        }

        // GET: People/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Birth")] PersonDBO personDBO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personDBO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personDBO);
        }

        // GET: People/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personDBO = await _context.People.FindAsync(id);
            if (personDBO == null)
            {
                return NotFound();
            }
            return View(personDBO);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Birth")] PersonDBO personDBO)
        {
            if (id != personDBO.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personDBO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonDBOExists(personDBO.Id))
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
            return View(personDBO);
        }

        // GET: People/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personDBO = await _context.People
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personDBO == null)
            {
                return NotFound();
            }

            return View(personDBO);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personDBO = await _context.People.FindAsync(id);
            _context.People.Remove(personDBO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonDBOExists(int id)
        {
            return _context.People.Any(e => e.Id == id);
        }
    }
}
