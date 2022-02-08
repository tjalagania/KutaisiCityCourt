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
    public class AboutController : Controller
    {
        private readonly KcDbContext _db;
        public AboutController(KcDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            MainAboutViewModel abw = new MainAboutViewModel();
            abw.Abouts = await _db.About.OrderBy(ab => ab.id).ToListAsync();
            abw.Struct = await _db.Structura.FirstAsync();
            abw.Files = await _db.AboutAtachFiles.ToListAsync();
            return View(abw);
        }
    }
}
