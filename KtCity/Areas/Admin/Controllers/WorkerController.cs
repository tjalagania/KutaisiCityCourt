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
    public class WorkerController : Controller
    {
        private readonly KcDbContext _db;
        private readonly CiteHelper _help;
        private readonly IWebHostEnvironment _env;
        public WorkerController(KcDbContext db,CiteHelper help,
            IWebHostEnvironment env
            )
        {
            _db = db;
            _help = help;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Worker> workers = await _db.Workers.Include(w=>w.Position).ToListAsync();
            return View(workers);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            WorkerViewModel wk = new WorkerViewModel();
            wk.Positions = await _db.Positions.OrderBy(p=>p.Rang).ToListAsync();
            return View(wk);
        }
        [HttpPost]
        public async Task<IActionResult> Create(WorkerViewModel wk, IFormFile img,int position)
        {
            if (ModelState.IsValid)
            {
                Position ps = await _db.Positions.FirstOrDefaultAsync(m => m.id == position);
                if(ps != null)
                {
                    wk.Worker.Position = ps;
                }
                if(img != null)
                {
                    string imgpat = Path.Combine(_env.WebRootPath, ConfigClass.ImageFolder);
                    string imgname= await _help.CopyFile(img, imgpat, _env);
                    wk.Worker.Image = imgname;
                }
                _db.Workers.Add(wk.Worker);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            wk.Positions = await _db.Positions.OrderBy(m=>m.Rang).ToListAsync();
            return View(wk);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Worker wk = await _db.Workers.Include(w => w.Position)
                .FirstOrDefaultAsync(m => m.id == id);
    
            if (wk == null) return NotFound();
            WorkerViewModel wkm = new WorkerViewModel()
            {
                Worker = wk,
                Positions = await _db.Positions.ToListAsync()
            };
            return View(wkm);
        }
        [HttpPost]
        public async Task<IActionResult>Edit(WorkerViewModel wk, IFormFile img,
            int position
            )
        {
            if (ModelState.IsValid)
            {
                Worker wkk = await _db.Workers.FindAsync(wk.Worker.id);
                
                if (img != null)
                {
                    string imgp = Path.Combine(_env.WebRootPath, ConfigClass.ImageFolder);
                    if(!string.IsNullOrEmpty(wkk.Image))
                        _help.DelteImg(wkk.Image, imgp);
                   wkk.Image = await _help.CopyFile(img, imgp, _env);
                }
                
                Position ps = await _db.Positions.FindAsync(position);
                
                wkk.FirstName = wk.Worker.FirstName;
                wkk.LastName = wk.Worker.LastName;
                wkk.Emal = wk.Worker.Emal;
                wkk.Biography = wk.Worker.Biography;
                wkk.Birthday = wk.Worker.Birthday;
                wkk.Position = ps;
                _db.Workers.Update(wkk);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            wk.Positions = await _db.Positions.ToListAsync();
            return View(wk);
        }
        [Route("api/worker/delete")]
        [HttpDelete]
        public async Task<IActionResult>Delete(int? id)
        {
            if (id == null)
                return NotFound();
            Worker wk = await _db.Workers.FindAsync(id);
            if (wk == null) return NotFound();
            if (!string.IsNullOrEmpty(wk.Image))
            {
                string imgp = Path.Combine(_env.WebRootPath, ConfigClass.ImageFolder);
                _help.DelteImg(wk.Image, imgp);
            }
            _db.Workers.Remove(wk);
            await _db.SaveChangesAsync();
            return Json(new { msg = "success" });
        }
    }
}
