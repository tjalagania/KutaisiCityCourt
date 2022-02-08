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
    public class GaleryController : Controller
    {
        public readonly KcDbContext _db;
        public readonly CiteHelper _help;
        public readonly IWebHostEnvironment _env;
        public GaleryController(KcDbContext db,
            CiteHelper help, IWebHostEnvironment env
            )
        {
            _db = db;
            _help = help;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            GaleryViewModel glw = new GaleryViewModel();
            glw.Galeries = await _db.Galeries.ToListAsync();
            return View(glw);
        }
        public async Task<IActionResult> Create(GaleryViewModel glw
            , IFormFile cover)
        {
            if (ModelState.IsValid)
            {
                if (cover != null)
                {
                    string coverp = Path.Combine(_env.WebRootPath, ConfigClass.GaleryFolder);
                    glw.Galery.Cover = await _help.CopyFile(cover, coverp, _env);
                }
                await _db.Galeries.AddAsync(glw.Galery);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            return View(glw);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();
            Galery gl = await _db.Galeries.Include(m => m.Images)
                 .FirstOrDefaultAsync(m => m.id == id);
            if (gl == null) return NotFound();
            return View(gl);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Galery gl, List<IFormFile> imgs,
            IFormFile cover)
        {
            if (ModelState.IsValid)
            {
                Galery glr = await _db.Galeries.Include(m => m.Images)
                         .FirstOrDefaultAsync(m => m.id == gl.id);
                string coverp = Path.Combine(_env.WebRootPath, ConfigClass.GaleryFolder);
                if (cover != null)
                {
                    if (!string.IsNullOrEmpty(glr.Cover))
                    {

                        _help.DelteImg(glr.Cover, coverp);
                    }
                    glr.Cover = await _help.CopyFile(cover, coverp, _env);
                }
                if (imgs.Count > 0)
                {

                    List<string> imgnames =
                         await _help.CopyFiles(imgs,
                         Path.Combine(_env.WebRootPath, ConfigClass.GaleryFolder),
                             _env
                        );
                    foreach (var s in imgnames)
                    {
                        glr.Images.Add(new GaleryImgs()
                        {
                            ImgName = s
                        });
                    }
                }
                glr.Name = gl.Name;
                _db.Galeries.Update(glr);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Edit), new { id = gl.id });
            }
            return View(gl);
        }
        [HttpDelete]
        [Route("api/galery/deleteimg")]
        public async Task<IActionResult> DeleteImg(int? id)
        {
            if (id == null) return NotFound();
            GaleryImgs glimg = await _db.GaleryImages.FindAsync(id);
            if (glimg == null) return NotFound();
            if (!string.IsNullOrEmpty(glimg.ImgName))
            {
                string imgp = Path.Combine(_env.WebRootPath,
                    ConfigClass.GaleryFolder);
                _help.DelteImg(glimg.ImgName, imgp);
            }
            _db.GaleryImages.Remove(glimg);
            await _db.SaveChangesAsync();
            return Json(new { msg = "success" });
        }
        [HttpDelete]
        [Route("api/galery/deletegalery")]
        public async Task<IActionResult> DeleteGalery(int? id)
        {
            if (id == null)
                throw new Exception("გალერეას იდ არასწორია");
            Galery gl = await _db.Galeries
                .Include(m => m.Images)
                .FirstOrDefaultAsync(m => m.id == id);

            if (gl == null)
            {
                throw new Exception("შესაბამისი გალერა ვერ მოიძებნა");
            }
            string imgpath = Path.Combine(_env.WebRootPath, ConfigClass.GaleryFolder);
            if (!string.IsNullOrEmpty(gl.Cover))
            {
                _help.DelteImg(gl.Cover, imgpath);
            }
            if (gl.Images != null || gl.Images.Count > 0)
            {
                
                foreach(var item in gl.Images)
                {
                    _help.DelteImg(item.ImgName, imgpath);
                    GaleryImgs glimg = await _db.GaleryImages.FindAsync(item.id);
                    _db.Remove(glimg);
                }
                gl.Images.Clear();

            }
            _db.Galeries.Remove(gl);
            await _db.SaveChangesAsync();
            return Json(new { msg = "success" });
        }
    }
    
}
