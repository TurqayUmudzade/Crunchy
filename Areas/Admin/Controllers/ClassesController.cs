using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Crunch.Data;
using Crunch.Models;
using Crunch.Areas.Admin.Authentication;

namespace Crunch.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(CheckAdminAuth))]
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Class @class)
        {
            if (ModelState.IsValid)
            {
                if (@class.type == "bg-blue")
                    @class.icon = "fas fa-dumbbell";
                if (@class.type == "bg-pickle")
                    @class.icon = "fas fa-weight";
                if (@class.type == "bg-pink")
                    @class.icon = "none";

                @class.gym = _context.gyms.Find(@class.gym.gymID);
                _context.Add(@class);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
                return Content(string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)));

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
