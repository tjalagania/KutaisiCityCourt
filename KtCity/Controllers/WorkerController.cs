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
    public class WorkerController : Controller
    {
        private readonly KcDbContext _db;
        public WorkerController(KcDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            MainWorkerViewModel wrkw = new MainWorkerViewModel();

            var positions = await _db.Positions.Where(p=>p.Rang !=1).Select(p=>p.Rang).ToListAsync();
            
            foreach(var rang in positions)
            {
                var tmp = await _db.Workers.Include(m => m.Position)
                    .Where(m => m.Position.Rang == rang).OrderBy(m=>m.id)
                    .ToListAsync();
                List<Person> tmpperson = new List<Person>();
                tmpperson.AddRange(tmp);
                wrkw.Persons.Add(tmpperson);
            }
            wrkw.Manager = await _db.Workers.
                Include(w => w.Position)
                .FirstOrDefaultAsync(w => w.Position.Rang == 1);
            
            return View(wrkw);
        }
        public async Task<IActionResult>Once(int? id)
        {
            if (id == null)
                return RedirectToAction(nameof(Index));
            Worker wk = await _db.Workers.FindAsync(id);
            if (wk == null)
                return RedirectToAction(nameof(Index));
            ViewData["Title"] = $"{wk.FirstName} {wk.LastName}";
            return View(wk);
        }
    }
}
