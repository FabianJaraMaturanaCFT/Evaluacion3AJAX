﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Evaluacion3AJAX.Data;
using Evaluacion3AJAX.Models;

namespace Evaluacion3AJAX.Controllers
{
    public class MantenimientoHerramientasController : Controller
    {
        private readonly ProyectoDbContext _context;

        public MantenimientoHerramientasController(ProyectoDbContext context)
        {
            _context = context;
        }

        // GET: MantenimientoHerramientas
        public async Task<IActionResult> Index()
        {
            var proyectoDbContext = _context.MantenimientoHerramientas.Include(m => m.UnidadHerramienta);
            return View(await proyectoDbContext.ToListAsync());
        }

        // GET: MantenimientoHerramientas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MantenimientoHerramientas == null)
            {
                return NotFound();
            }

            var mantenimientoHerramienta = await _context.MantenimientoHerramientas
                .Include(m => m.UnidadHerramienta)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mantenimientoHerramienta == null)
            {
                return NotFound();
            }

            return View(mantenimientoHerramienta);
        }

        // GET: MantenimientoHerramientas/Create
        public IActionResult Create()
        {
            ViewData["UnidadHerramientaId"] = new SelectList(_context.UnidadHerramientas, "Id", "Estado");
            return View();
        }

        // POST: MantenimientoHerramientas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UnidadHerramientaId,FechaInicio,FechaFin")] MantenimientoHerramienta mantenimientoHerramienta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mantenimientoHerramienta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UnidadHerramientaId"] = new SelectList(_context.UnidadHerramientas, "Id", "Estado", mantenimientoHerramienta.UnidadHerramientaId);
            return View(mantenimientoHerramienta);
        }

        // GET: MantenimientoHerramientas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MantenimientoHerramientas == null)
            {
                return NotFound();
            }

            var mantenimientoHerramienta = await _context.MantenimientoHerramientas.FindAsync(id);
            if (mantenimientoHerramienta == null)
            {
                return NotFound();
            }
            ViewData["UnidadHerramientaId"] = new SelectList(_context.UnidadHerramientas, "Id", "Estado", mantenimientoHerramienta.UnidadHerramientaId);
            return View(mantenimientoHerramienta);
        }

        // POST: MantenimientoHerramientas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UnidadHerramientaId,FechaInicio,FechaFin")] MantenimientoHerramienta mantenimientoHerramienta)
        {
            if (id != mantenimientoHerramienta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mantenimientoHerramienta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MantenimientoHerramientaExists(mantenimientoHerramienta.Id))
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
            ViewData["UnidadHerramientaId"] = new SelectList(_context.UnidadHerramientas, "Id", "Estado", mantenimientoHerramienta.UnidadHerramientaId);
            return View(mantenimientoHerramienta);
        }

        // GET: MantenimientoHerramientas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MantenimientoHerramientas == null)
            {
                return NotFound();
            }

            var mantenimientoHerramienta = await _context.MantenimientoHerramientas
                .Include(m => m.UnidadHerramienta)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mantenimientoHerramienta == null)
            {
                return NotFound();
            }

            return View(mantenimientoHerramienta);
        }

        // POST: MantenimientoHerramientas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MantenimientoHerramientas == null)
            {
                return Problem("Entity set 'ProyectoDbContext.MantenimientoHerramientas'  is null.");
            }
            var mantenimientoHerramienta = await _context.MantenimientoHerramientas.FindAsync(id);
            if (mantenimientoHerramienta != null)
            {
                _context.MantenimientoHerramientas.Remove(mantenimientoHerramienta);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MantenimientoHerramientaExists(int id)
        {
          return (_context.MantenimientoHerramientas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
