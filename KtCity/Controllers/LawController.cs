using KtCity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Controllers
{
    public class LawController : Controller
    {
        private readonly KcDbContext _db;
        public LawController(KcDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<links> lnk = await _db.Links.ToListAsync();
            return View(lnk);
        }
    }
}
