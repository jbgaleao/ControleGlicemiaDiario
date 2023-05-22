using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleGlicemiaDiario.Data;
using ControleGlicemiaDiario.ViewModels;

namespace ControleGlicemiaDiario.Controllers
{
    public class GlicemiasController : Controller
    {
        private readonly GlicemiaContext _context;

        public GlicemiasController(GlicemiaContext context)
        {
            _context = context;
        }

        // GET: Glicemias
        public async Task<IActionResult> Index()
        {
              return _context.GlicemiaVM != null ? 
                          View(await _context.GlicemiaVM.ToListAsync()) :
                          Problem("Entity set 'GlicemiaContext.GlicemiaVM'  is null.");
        }

        // GET: Glicemias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.GlicemiaVM == null)
            {
                return NotFound();
            }

            var glicemiaVM = await _context.GlicemiaVM
                .FirstOrDefaultAsync(m => m.Id == id);
            if (glicemiaVM == null)
            {
                return NotFound();
            }

            return View(glicemiaVM);
        }

        // GET: Glicemias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Glicemias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataHoraMedicao,DataHoraAplicação,GlicemiaMedida,DoseRegular,DoseAjuste,Observacao")] GlicemiaVM glicemiaVM)
        {
            if (ModelState.IsValid)
            {
                _context.Add(glicemiaVM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(glicemiaVM);
        }

        // GET: Glicemias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.GlicemiaVM == null)
            {
                return NotFound();
            }

            var glicemiaVM = await _context.GlicemiaVM.FindAsync(id);
            if (glicemiaVM == null)
            {
                return NotFound();
            }
            return View(glicemiaVM);
        }

        // POST: Glicemias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataHoraMedicao,DataHoraAplicação,GlicemiaMedida,DoseRegular,DoseAjuste,Observacao")] GlicemiaVM glicemiaVM)
        {
            if (id != glicemiaVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(glicemiaVM);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GlicemiaVMExists(glicemiaVM.Id))
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
            return View(glicemiaVM);
        }

        // GET: Glicemias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.GlicemiaVM == null)
            {
                return NotFound();
            }

            var glicemiaVM = await _context.GlicemiaVM
                .FirstOrDefaultAsync(m => m.Id == id);
            if (glicemiaVM == null)
            {
                return NotFound();
            }

            return View(glicemiaVM);
        }

        // POST: Glicemias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.GlicemiaVM == null)
            {
                return Problem("Entity set 'GlicemiaContext.GlicemiaVM'  is null.");
            }
            var glicemiaVM = await _context.GlicemiaVM.FindAsync(id);
            if (glicemiaVM != null)
            {
                _context.GlicemiaVM.Remove(glicemiaVM);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GlicemiaVMExists(int id)
        {
          return (_context.GlicemiaVM?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
