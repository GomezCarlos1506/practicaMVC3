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
    public class LIBROesController : Controller
    {
        private readonly LibroContext _context;

        public LIBROesController(LibroContext context)
        {
            _context = context;
        }

        // GET: LIBROes
        public async Task<IActionResult> Index()
        {
            return View(await _context.LIBRO.ToListAsync());
        }

        // GET: LIBROes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIBRO = await _context.LIBRO
                .FirstOrDefaultAsync(m => m.IDLibro == id);
            if (lIBRO == null)
            {
                return NotFound();
            }

            return View(lIBRO);
        }

        // GET: LIBROes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LIBROes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDLibro,ISBN,TITULO,AUTOR,IDEditorial,Año,PRECIO,COMENTARIOS,FOTO")] LIBRO lIBRO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lIBRO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lIBRO);
        }

        // GET: LIBROes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIBRO = await _context.LIBRO.FindAsync(id);
            if (lIBRO == null)
            {
                return NotFound();
            }
            return View(lIBRO);
        }

        // POST: LIBROes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDLibro,ISBN,TITULO,AUTOR,IDEditorial,Año,PRECIO,COMENTARIOS,FOTO")] LIBRO lIBRO)
        {
            if (id != lIBRO.IDLibro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lIBRO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LIBROExists(lIBRO.IDLibro))
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
            return View(lIBRO);
        }

        // GET: LIBROes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIBRO = await _context.LIBRO
                .FirstOrDefaultAsync(m => m.IDLibro == id);
            if (lIBRO == null)
            {
                return NotFound();
            }

            return View(lIBRO);
        }

        // POST: LIBROes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lIBRO = await _context.LIBRO.FindAsync(id);
            if (lIBRO != null)
            {
                _context.LIBRO.Remove(lIBRO);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LIBROExists(int id)
        {
            return _context.LIBRO.Any(e => e.IDLibro == id);
        }
    }
}
