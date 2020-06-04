using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crunch.Data;
using Crunch.Models;

namespace Crunch.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClassesController : Controller
    {
        private readonly Context _context;

        public ClassesController(Context context)
        {
            _context = context;
        }

        // GET: Admin/Classes
        public async Task<IActionResult> Index()
        {
            return View(await _context.classes.ToListAsync());
        }

        // GET: Admin/Classes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @class = await _context.classes
                .FirstOrDefaultAsync(m => m.ClassID == id);
            if (@class == null)
            {
                return NotFound();
            }

            return View(@class);
        }

        // GET: Admin/Classes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Classes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClassID,name,description,duration,dateTime,space,spaceUsed,type,icon")] Class @class)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@class);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@class);
        }

        // GET: Admin/Classes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @class = await _context.classes.FindAsync(id);
            if (@class == null)
            {
                return NotFound();
            }
            return View(@class);
        }

        // POST: Admin/Classes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClassID,name,description,duration,dateTime,space,spaceUsed,type,icon")] Class @class)
        {
            if (id != @class.ClassID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@class);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassExists(@class.ClassID))
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
            return View(@class);
        }

        // GET: Admin/Classes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @class = await _context.classes
                .FirstOrDefaultAsync(m => m.ClassID == id);
            if (@class == null)
            {
                return NotFound();
            }

            return View(@class);
        }

        // POST: Admin/Classes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @class = await _context.classes.FindAsync(id);
            _context.classes.Remove(@class);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassExists(int id)
        {
            return _context.classes.Any(e => e.ClassID == id);
        }
    }
}
