using KtCity.Models;
using KtCity.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AboutController : Controller
    {
        private readonly KcDbContext _db;
        private readonly CiteHelper _help;
        private readonly IWebHostEnvironment _env;
        public AboutController(KcDbContext db,CiteHelper help,
            IWebHostEnvironment env
            )
        {
            _db = db;
            _help = help;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<About> abouts = await _db.About
                .
                ToListAsync();
            return View(abouts);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Create(About eb,
            IFormFile img)
        {
            if (ModelState.IsValid)
            {
                string imgp = Path.Combine(_env.WebRootPath, ConfigClass.ImageFolder);
                string filp = Path.Combine(_env.WebRootPath, ConfigClass.FileFolder);
                if (img != null)
                {
                    eb.Image = await _help.CopyFile(img, imgp, _env);
                }

                
               
                _db.About.Add(eb);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
               
            }
            return View(eb);
        }
        [HttpGet]
        public async Task<IActionResult>Edit(int id)
        {
            About ab = await _db.About.FindAsync(id);
            return View(ab);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(About ab,IFormFile img)
        {
            if (ModelState.IsValid)
            {
                About about = await _db.About.FindAsync(ab.id);

                if(img != null)
                {
                    string imgp = Path.Combine(_env.WebRootPath, ConfigClass.ImageFolder);
                    if (!string.IsNullOrEmpty(about.Image))
                        _help.DelteImg(about.Image, imgp);
                    about.Image = await _help.CopyFile(img, imgp, _env);
                }
                about.Name = ab.Name;
                about.Description = ab.Description;
                about.EmailString = ab.EmailString;
                about.Address = ab.Address;
                
                about.RekviziteStrng = ab.RekviziteStrng;
                about.Text = ab.Text;
               _db.About.Update(about);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ab);
        }
        [Route("api/about/delete")]
        [HttpDelete]
        public async Task<IActionResult>Delete(int? id)
        {
            if(id ==null)
            {
                throw new Exception("id is not be null");
            }
            About ab = await _db.About.FindAsync(id);
            if (ab == null)
                throw new Exception("about is null");
            if(!string.IsNullOrEmpty(ab.Image))
            {
                string imgp = Path.Combine(_env.WebRootPath, ConfigClass.ImageFolder);
                _help.DelteImg(ab.Image, imgp); 
            }
            _db.About.Remove(ab);
            await _db.SaveChangesAsync();
            return Json(new { msg = "success" });
        }
    }
}
