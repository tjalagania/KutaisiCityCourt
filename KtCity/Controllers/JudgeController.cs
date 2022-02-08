using KtCity.Models;
using KtCity.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Controllers
{
    public class JudgeController : Controller
    {
        private readonly KcDbContext _db;
        public JudgeController(KcDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            MainWorkerViewModel jdw = new MainWorkerViewModel();
            jdw.Manager =(Person) await _db.Judges.Include(m=>m.Position).FirstOrDefaultAsync(m => m.Chariman == true);
            var tmp = await _db.Judges.Include(m=>m.Position).Where(m => m.Chariman == false)
                .OrderBy(m=>m.Position.Rang).ToListAsync();
            jdw.Workers.AddRange(tmp.Take(4).ToList());
            jdw.SecondLine.AddRange(tmp.Skip(4).ToList());
            if ((jdw.SecondLine.Count / 8) == 0)
            {
                jdw.Lines = 1;
            }
            else if ((jdw.SecondLine.Count % 8) > 0)
            {
                jdw.Lines = jdw.SecondLine.Count / 8 + 1;
            }
            else
            {
                jdw.Lines = jdw.SecondLine.Count / 8;
            }
            return View(jdw);
        }
        public async Task<IActionResult>Once(int? id)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Index));
            }
            Judge jd = await _db.Judges.Include(jdg => jdg.Aparati)
                .ThenInclude(wk=>wk.Position)
                .FirstOrDefaultAsync(jdg => jdg.id == id);

            if (jd == null)
                return RedirectToAction(nameof(Index));
            jd.Aparati = jd.Aparati.OrderBy(m => m.Position.Rang).ToList();
            ViewData["Title"] = $"{jd.FirstName} {jd.LastName}";
            return View(jd);
        }
    }
}
