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
    public class EDITORIALsController : Controller
    {
        private readonly LibroContext _context;

        public EDITORIALsController(LibroContext context)
        {
            _context = context;
        }

        // GET: EDITORIALs
        public async Task<IActionResult> Index()
        {
            return View(await _context.EDITORIAL.ToListAsync());
        }

        // GET: EDITORIALs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eDITORIAL = await _context.EDITORIAL
                .FirstOrDefaultAsync(m => m.IDEditorial == id);
            if (eDITORIAL == null)
            {
                return NotFound();
            }

            return View(eDITORIAL);
        }

        // GET: EDITORIALs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EDITORIALs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDEditorial,Editorial,Nombre_del_contacto,Direccion,Ciudad,Telefono,Email,Comentario")] EDITORIAL eDITORIAL)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eDITORIAL);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eDITORIAL);
        }

        // GET: EDITORIALs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eDITORIAL = await _context.EDITORIAL.FindAsync(id);
            if (eDITORIAL == null)
            {
                return NotFound();
            }
            return View(eDITORIAL);
        }

        // POST: EDITORIALs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDEditorial,Editorial,Nombre_del_contacto,Direccion,Ciudad,Telefono,Email,Comentario")] EDITORIAL eDITORIAL)
        {
            if (id != eDITORIAL.IDEditorial)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eDITORIAL);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EDITORIALExists(eDITORIAL.IDEditorial))
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
            return View(eDITORIAL);
        }

        // GET: EDITORIALs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eDITORIAL = await _context.EDITORIAL
                .FirstOrDefaultAsync(m => m.IDEditorial == id);
            if (eDITORIAL == null)
            {
                return NotFound();
            }

            return View(eDITORIAL);
        }

        // POST: EDITORIALs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eDITORIAL = await _context.EDITORIAL.FindAsync(id);
            if (eDITORIAL != null)
            {
                _context.EDITORIAL.Remove(eDITORIAL);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EDITORIALExists(int id)
        {
            return _context.EDITORIAL.Any(e => e.IDEditorial == id);
        }
    }
}
