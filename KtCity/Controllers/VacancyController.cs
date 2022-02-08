using KtCity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Controllers
{
    public class VacancyController : Controller
    {
        private readonly KcDbContext _db;
        public VacancyController(KcDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index(int p =0, int s = 12)
        {
            if (p > 0)
            {
                p--;
            }
            ViewBag.AllCount = await _db.Vacancies.CountAsync();
            List<NewsItem> news = new();
            news.AddRange(await _db.Vacancies.OrderByDescending(wc=>wc.id).Skip(p * s).Take(s).ToListAsync());
            return View(news);
        }
        public async Task<IActionResult>Once(int? id)
        {
            if (id == null)
                return RedirectToAction(nameof(Index));
            NewsItem nw = await _db.Vacancies.Include(m => m.AttachFiles).FirstOrDefaultAsync(m => m.id == id);
            if (nw == null)
                return RedirectToAction(nameof(Index));
            ViewData["Title"] = nw.Title;
            return View(nw);
        }
    }
}
