using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using practica3.Context;
using practica3.Models;

namespace practica3.Controllers
{
    public class INVENTARIOsController : Controller
    {
        private readonly LibroContext _context;

        public INVENTARIOsController(LibroContext context)
        {
            _context = context;
        }

        // GET: INVENTARIOs
        public async Task<IActionResult> Index()
        {
            return View(await _context.INVENTARIO.ToListAsync());
        }

        // GET: INVENTARIOs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iNVENTARIO = await _context.INVENTARIO
                .FirstOrDefaultAsync(m => m.IDinventario == id);
            if (iNVENTARIO == null)
            {
                return NotFound();
            }

            return View(iNVENTARIO);
        }

        // GET: INVENTARIOs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: INVENTARIOs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDinventario,IDLibro,IDSucursal,Existencia")] INVENTARIO iNVENTARIO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(iNVENTARIO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iNVENTARIO);
        }

        // GET: INVENTARIOs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iNVENTARIO = await _context.INVENTARIO.FindAsync(id);
            if (iNVENTARIO == null)
            {
                return NotFound();
            }
            return View(iNVENTARIO);
        }

        // POST: INVENTARIOs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDinventario,IDLibro,IDSucursal,Existencia")] INVENTARIO iNVENTARIO)
        {
            if (id != iNVENTARIO.IDinventario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iNVENTARIO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!INVENTARIOExists(iNVENTARIO.IDinventario))
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
            return View(iNVENTARIO);
        }

        // GET: INVENTARIOs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iNVENTARIO = await _context.INVENTARIO
                .FirstOrDefaultAsync(m => m.IDinventario == id);
            if (iNVENTARIO == null)
            {
                return NotFound();
            }

            return View(iNVENTARIO);
        }

        // POST: INVENTARIOs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var iNVENTARIO = await _context.INVENTARIO.FindAsync(id);
            if (iNVENTARIO != null)
            {
                _context.INVENTARIO.Remove(iNVENTARIO);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool INVENTARIOExists(int id)
        {
            return _context.INVENTARIO.Any(e => e.IDinventario == id);
        }
    }
}
