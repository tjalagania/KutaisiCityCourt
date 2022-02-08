using KtCity.Models;
using KtCity.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class CouncilController : Controller
    {
        private readonly KcDbContext _db;
        public CouncilController(KcDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            PalatAndPalatsList plts = new PalatAndPalatsList();
            plts.PalatList = await _db.Palats.OrderBy(m=>m.Rang)
                 .ToListAsync();
            return View(plts);
        }
        [HttpPost]
        public async Task<IActionResult>Create(PalatAndPalatsList plts)
        {
            if (ModelState.IsValid)
            {
                _db.Palats.Add(plts.Palat);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            plts.PalatList = await _db.Palats.ToListAsync();
            return View(plts);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Palats pl = await _db.Palats.FindAsync(id);
            if (pl == null)
                return NotFound();
            return View(pl);
        }
        [HttpPost]
        public async Task<IActionResult>Edit(Palats pl)
        {
            if (ModelState.IsValid)
            {
                Palats p = await _db.Palats.FindAsync(pl.id);
                p.Name = pl.Name;
                p.Rang = pl.Rang;
                _db.Palats.Update(p);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pl);
        }
        [Route("api/council/delete")]
        [HttpDelete]
        public async Task<IActionResult>Delete(int? id)
        {
            if (id == null)
                return NotFound();
            Palats pl = await _db.Palats.Include(m=>m.Judges)
                .FirstOrDefaultAsync(m=>m.id == id);
            if (pl == null) return NotFound();
            if (pl.Judges != null)
                pl.Judges.Clear();
            _db.Palats.Remove(pl);
            await _db.SaveChangesAsync();
            return Json(new { msg = "success" });
        }
    }
}
