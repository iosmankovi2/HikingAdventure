using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hiking_Adventures.Data;
using Hiking_Adventures.Models;

namespace Hiking_Adventures.Controllers
{
    public class PrijavaRuteController : Controller
    {
        private readonly Data2Context _context;

        public PrijavaRuteController(Data2Context context)
        {
            _context = context;
        }

        // GET: PrijavaRute
        public async Task<IActionResult> Index()
        {
            return View(await _context.PrijavaRute.ToListAsync());
        }

        // GET: PrijavaRute/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavaRute = await _context.PrijavaRute
                .FirstOrDefaultAsync(m => m.ID == id);
            if (prijavaRute == null)
            {
                return NotFound();
            }

            return View(prijavaRute);
        }

        // GET: PrijavaRute/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PrijavaRute/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Ime,Prezime,Datum,eMail")] PrijavaRute prijavaRute)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prijavaRute);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: PrijavaRute/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavaRute = await _context.PrijavaRute.FindAsync(id);
            if (prijavaRute == null)
            {
                return NotFound();
            }
            return View(prijavaRute);
        }

        // POST: PrijavaRute/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Ime,Prezime,DatumRodjenja,eMail")] PrijavaRute prijavaRute)
        {
            if (id != prijavaRute.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prijavaRute);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrijavaRuteExists(prijavaRute.ID))
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
            return View(prijavaRute);
        }

        // GET: PrijavaRute/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijavaRute = await _context.PrijavaRute
                .FirstOrDefaultAsync(m => m.ID == id);
            if (prijavaRute == null)
            {
                return NotFound();
            }

            return View(prijavaRute);
        }

        // POST: PrijavaRute/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prijavaRute = await _context.PrijavaRute.FindAsync(id);
            _context.PrijavaRute.Remove(prijavaRute);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrijavaRuteExists(int id)
        {
            return _context.PrijavaRute.Any(e => e.ID == id);
        }
    }
}
