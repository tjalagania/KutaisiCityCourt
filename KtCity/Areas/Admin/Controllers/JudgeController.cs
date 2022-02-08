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
    public class JudgeController : Controller
    {
        private readonly KcDbContext _db;
        private readonly CiteHelper _help;
        private readonly IWebHostEnvironment _env;
        public JudgeController(KcDbContext db,
             CiteHelper help, IWebHostEnvironment env
            )
        {
            _db = db;
            _help = help;
            _env = env;
        }
        public async  Task<IActionResult> Index()
        {
            List<Judge> judges = await _db.Judges
                .Include(m=>m.Position).OrderBy(m=>m.Position.Rang)
                .ToListAsync();
            return View(judges);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            JudgeViewModel jdv = new JudgeViewModel();
            jdv.Palats = await _db.Palats.ToListAsync();
            jdv.Workers = await _db.Workers.Include(m => m.Position)
                .Where(m => m.Position.Rang == 2 || m.Position.Rang == 3).ToListAsync();
            return View(jdv);
        }
        [HttpPost]
        public async Task<IActionResult> Create(JudgeViewModel jdw,
            IFormFile img,int? palats,List<int>wrk)
        {
            if (ModelState.IsValid)
            {
                if(img != null)
                {
                    string imgp = Path.Combine(_env.WebRootPath, ConfigClass.ImageFolder);
                    jdw.Judge.Image = await _help.CopyFile(img, imgp, _env);
                }
                if(palats != null)
                {
                    jdw.Judge.Position = await _db.Palats.FindAsync(palats);
                }
                if (wrk.Count > 0)
                {
                    foreach(int w in wrk)
                    {
                        Worker wk = await _db.Workers.FindAsync(w);
                        jdw.Workers.Add(wk);
                    }
                }
                _db.Judges.Add(jdw.Judge);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            jdw.Palats = await _db.Palats.ToListAsync();
            return View(jdw);
        }
        [HttpGet]
        public async Task<IActionResult>Edit(int? id)
        {
            if (id == null) return NotFound();
            JudgeViewModel jdv = new JudgeViewModel();
            jdv.Judge = await _db.Judges.Include(m => m.Position)
                .FirstOrDefaultAsync(m => m.id == id);
            if (jdv.Judge == null)
                return NotFound();

            jdv.Palats = await _db.Palats
                .OrderBy(m=>m.Rang)
                .ToListAsync();
            jdv.Workers = await _db.Workers.Include(w => w.Position)
                .Where(w => w.Position.Rang == 2 || w.Position.Rang == 3).ToListAsync();
            return View(jdv);
        }
        [HttpPost]
        public async Task<IActionResult>Edit(JudgeViewModel jdv,
            IFormFile img, int palats,List<int>wrk)
        {
            if (ModelState.IsValid)
            {
                Judge jd = await _db.Judges.Include(m => m.Position).Include(m=>m.Aparati)
                    .FirstOrDefaultAsync(m => m.id == jdv.Judge.id);
                if(img != null)
                {
                    string imgp = Path.Combine(_env.WebRootPath, ConfigClass.ImageFolder);
                    if (!string.IsNullOrEmpty(jd.Image))
                        _help.DelteImg(jd.Image, imgp);
                    jd.Image = await _help.CopyFile(img, imgp, _env);
                }
                jd.Position = await _db.Palats.FindAsync(palats);
                jd.Copy(jdv.Judge);
                if (wrk.Count > 0)
                {
                    jd.Aparati.Clear();
                    foreach(int i in wrk)
                    {
                        Worker wk = await _db.Workers.FindAsync(i);
                        jd.Aparati.Add(wk);
                    }
                }
                _db.Judges.Update(jd);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            jdv.Palats = await _db.Palats.ToListAsync();
            return View(jdv);
        }
        [Route("api/judge/delete")]
        [HttpDelete]
        public async Task<IActionResult>Delete(int? id)
        {
            if (id == null) return NotFound();
            Judge jd = await _db.Judges.Include(j=>j.Aparati).FirstOrDefaultAsync(j=>j.id ==id);
            
            if (jd == null) return NotFound();
            if (!string.IsNullOrEmpty(jd.Image))
            {
                string imgp = Path.Combine(_env.WebRootPath,ConfigClass.ImageFolder);
                _help.DelteImg(jd.Image, imgp);
            }
            jd.Aparati.Clear();
            _db.Judges.Remove(jd);
            await _db.SaveChangesAsync();
            return Json(new { msg = "success" });
        }
    }
}
