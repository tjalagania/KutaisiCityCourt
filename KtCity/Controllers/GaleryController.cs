using KtCity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Controllers
{
    public class GaleryController : Controller
    {
        private readonly KcDbContext _db;
        public GaleryController(KcDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index(int p = 0,int s = 12)
        {
            if (p > 0)
            {
                p--;
            }
            List<Galery> Galeries = await _db.Galeries.Skip(p * s).Take(s).ToListAsync();
            return View(model: Galeries);
        }
        public async Task<IActionResult>Once(int? id)
        {
            if (id == null)
                return RedirectToAction(nameof(Index));
            List<GaleryImgs> imgs = await _db.GaleryImages
                .Where(m => m.Galery.id == id)
                .ToListAsync();
            ViewData["Title"] = (await _db.Galeries.FirstOrDefaultAsync(m => m.id == id)).Name;
            return View(imgs);
        }
    }
}
