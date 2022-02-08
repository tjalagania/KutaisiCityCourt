using KtCity.Models;
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
    public class StatisticController : Controller
    {
        private readonly KcDbContext _db;
        public StatisticController(KcDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        { Statistic st;
            try
            {
               st = await _db.Statistic.FirstAsync();
            }
            catch (Exception ex)
            {
                st = new Statistic();
            }
  
            return View(st);
        }
        public async Task<IActionResult>Create(Statistic st)
        {
            if (ModelState.IsValid)
            {
                Statistic stt = await _db.Statistic.FindAsync(st.id);
                if(stt == null)
                {
                    await _db.Statistic.AddAsync(st);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    stt.StaticText = st.StaticText;
                    _db.Statistic.Update(stt);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(st);
        }
    }
}
