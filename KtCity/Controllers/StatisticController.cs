using KtCity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Controllers
{
    public class StatisticController : Controller
    {
        private readonly KcDbContext _db;
        public StatisticController(KcDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            Statistic st = await _db.Statistic.FirstAsync();
            return View(st);
        }
    }
}
