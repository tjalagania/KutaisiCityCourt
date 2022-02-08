using KtCity.Models;
using KtCity.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    
    public class HomeController : Controller
    {
        private readonly KcDbContext _db;
        public PositonAndPositionList model;
        public HomeController(KcDbContext db)
        {
            model = new PositonAndPositionList();
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            model.PostionList.AddRange(await _db.Positions.ToListAsync());
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Position position)
        {
            if (ModelState.IsValid)
            {
                await _db.Positions.AddAsync(position);
                await _db.SaveChangesAsync(); 
                
            }
            
            
            return RedirectToAction(nameof(Index));
        }
        [Route("api/position/delete")]
        [HttpDelete]
        public async Task<IActionResult>Delete(int? id)
        {
            if (id == null) return NotFound();
            Position p = await _db.Positions.FindAsync(id);
            if (p == null)
                return NotFound();
            _db.Positions.Remove(p);
            await _db.SaveChangesAsync();
            return Json(new {message="Ok" });
        }
        [HttpGet]
        public async Task<IActionResult>Edit(int? id)
        {
            if (id == null)
                return NotFound();
            Position p = await _db.Positions.FindAsync(id);
            if (p == null)
                NotFound();
            return View(p);
        }
        [HttpPost]
        public async Task<IActionResult>Edit(Position p)
        {
            if (ModelState.IsValid)
            {
                Position pp = await _db.Positions.FindAsync(p.id);
                pp.Name = p.Name;
                pp.Rang = p.Rang;
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(p);
        }
    }
}
