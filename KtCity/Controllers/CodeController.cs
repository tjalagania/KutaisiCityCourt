using KtCity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Controllers
{
    public class CodeController : Controller
    {
        private readonly KcDbContext _db;
        public CodeController(KcDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List <Cods> codes = await _db.Codes.OrderBy(m=>m.PositionInList)
                .ToListAsync();
            return View(codes);
        }
    }
}
