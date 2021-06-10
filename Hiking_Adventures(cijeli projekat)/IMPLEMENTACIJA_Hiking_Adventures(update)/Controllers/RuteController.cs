using Hiking_Adventure.Models;
using Hiking_Adventures_update_.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hiking_Adventures.Controllers
{
    public class RuteController : Controller
    {
        private readonly DataContext _context;


        public RuteController(DataContext context)
        {
            _context = context;
        }

        // GET: Rute

        public async Task<IActionResult> Index(string searchString)
        {

            var rute = from m in _context.Ruta
                       select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                rute = rute.Where(s => s.nazivRute.Contains(searchString));
            }

            return View(await rute.ToListAsync());
        }


        // GET: Rute/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruta = await _context.Ruta
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ruta == null)
            {
                return NotFound();
            }

            return View(ruta);
        }

        public async Task<IActionResult> Prijava_Rute(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruta = await _context.Ruta
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ruta == null)
            {
                return NotFound();
            }

            return View(ruta);
        }



        // GET: Rute/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rute/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        /*  public async Task<IActionResult> Create([Bind("ID,nazivRute")] Ruta ruta)
          {
              if (ModelState.IsValid)
              {
                  _context.Add(ruta);
                  await _context.SaveChangesAsync();
                  return RedirectToAction(nameof(Index));
              }
              return View(ruta);
          }
          */



        // GET: Rute/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruta = await _context.Ruta.FindAsync(id);
            if (ruta == null)
            {
                return NotFound();
            }
            return View(ruta);
        }

        // POST: Rute/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,nazivRute")] Ruta ruta)
        {
            if (id != ruta.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ruta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RutaExists(ruta.ID))
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
            return View(ruta);
        }

        // GET: Rute/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruta = await _context.Ruta
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ruta == null)
            {
                return NotFound();
            }

            return View(ruta);
        }

        // POST: Rute/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ruta = await _context.Ruta.FindAsync(id);
            _context.Ruta.Remove(ruta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RutaExists(int id)
        {
            return _context.Ruta.Any(e => e.ID == id);
        }
    }


}
