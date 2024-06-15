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
    public class SUCURSALsController : Controller
    {
        private readonly LibroContext _context;

        public SUCURSALsController(LibroContext context)
        {
            _context = context;
        }

        // GET: SUCURSALs
        public async Task<IActionResult> Index()
        {
            return View(await _context.SUCURSAL.ToListAsync());
        }

        // GET: SUCURSALs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sUCURSAL = await _context.SUCURSAL
                .FirstOrDefaultAsync(m => m.IDSucursal == id);
            if (sUCURSAL == null)
            {
                return NotFound();
            }

            return View(sUCURSAL);
        }

        // GET: SUCURSALs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SUCURSALs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDSucursal,Sucursal,Nombre_del_encargado,Direccion,Ciudad,Telefono,Email,comentario")] SUCURSAL sUCURSAL)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sUCURSAL);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sUCURSAL);
        }

        // GET: SUCURSALs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sUCURSAL = await _context.SUCURSAL.FindAsync(id);
            if (sUCURSAL == null)
            {
                return NotFound();
            }
            return View(sUCURSAL);
        }

        // POST: SUCURSALs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDSucursal,Sucursal,Nombre_del_encargado,Direccion,Ciudad,Telefono,Email,comentario")] SUCURSAL sUCURSAL)
        {
            if (id != sUCURSAL.IDSucursal)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sUCURSAL);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SUCURSALExists(sUCURSAL.IDSucursal))
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
            return View(sUCURSAL);
        }

        // GET: SUCURSALs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sUCURSAL = await _context.SUCURSAL
                .FirstOrDefaultAsync(m => m.IDSucursal == id);
            if (sUCURSAL == null)
            {
                return NotFound();
            }

            return View(sUCURSAL);
        }

        // POST: SUCURSALs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sUCURSAL = await _context.SUCURSAL.FindAsync(id);
            if (sUCURSAL != null)
            {
                _context.SUCURSAL.Remove(sUCURSAL);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SUCURSALExists(int id)
        {
            return _context.SUCURSAL.Any(e => e.IDSucursal == id);
        }
    }
}
