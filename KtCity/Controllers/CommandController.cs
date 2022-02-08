using KtCity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Controllers
{
    public class CommandController : Controller
    {
        private readonly KcDbContext _db;
        public CommandController(KcDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index(int p =0,int s = 12)
        {
            if (p > 0)
            {
                p--;
            }
            ViewBag.AllCount = await _db.Commands.CountAsync();
            List<NewsItem> news = new();
            news.AddRange(await _db.Commands.OrderByDescending(wc=>wc.id).Skip(p * s).Take(s).ToListAsync());
            
            return View(news);
        }
        public async Task<IActionResult>Once(int? id)
        {
            if (id == null)
                return RedirectToAction(nameof(Index));
            NewsItem cmd = await _db.Commands.Include(m => m.AttachFiles)
                .FirstOrDefaultAsync(m => m.id == id);
            if(cmd == null)
                return RedirectToAction(nameof(Index));
            ViewData["Title"] = cmd.Title;
            return View(cmd);
        }
    }
}
