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
    [Area("Admin")]
    [Authorize]
    public class LinkController : Controller
    {
        private readonly KcDbContext _db;
        public LinkController(KcDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            LinkViewModel lkw = new LinkViewModel();
            lkw.Links = await _db.Links.ToListAsync();
            return View(lkw);
        }
        public async Task<IActionResult>Create(LinkViewModel lnkw)
        {
            if (ModelState.IsValid)
            {
                await _db.Links.AddAsync(lnkw.Link);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lnkw);
        }
        [HttpGet]
        public async Task<IActionResult>Edit(int? id)
        {
            if (id == null) return NotFound();
            links lnk = await _db.Links.FindAsync(id);
            if (lnk == null) return NotFound();

            return View(lnk);
        }
        [HttpPost]
        public async Task<IActionResult>Edit(links lk)
        {
            if (ModelState.IsValid)
            {
                links tmplk = await _db.Links.FindAsync(lk.id);
                tmplk.Link = lk.Link;
                tmplk.Text = lk.Text;
                tmplk.PositinInLink = lk.PositinInLink;
                _db.Links.Update(tmplk);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lk);
        }
        [Route("api/link/delete")]
        [HttpDelete]
        public async Task<IActionResult>Delete(int? id)
        {
            if (id == null)
                throw new Exception("id isn't null");
            links lk = await _db.Links.FindAsync(id);
            if (lk == null)
                throw new Exception("Link is null");
            _db.Links.Remove(lk);
            await _db.SaveChangesAsync();
            return Json(new { msg = "success" });
        }
    }
   
}
