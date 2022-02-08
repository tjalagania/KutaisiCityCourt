using KtCity.Models;
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
    public class VacancyController : Controller
    {
        private readonly KcDbContext _db;
        private readonly CiteHelper _help;
        private readonly IWebHostEnvironment _env;
        public VacancyController(KcDbContext db,CiteHelper help,IWebHostEnvironment env)
        {
            _db = db;
            _help = help;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List <Vacancy>vcs = await _db.Vacancies.ToListAsync();
            return View(vcs);
        }
        
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Create(Vacancy vcs,List<IFormFile>files)
        {
            if (ModelState.IsValid)
            {
                if (files.Count > 0)
                {
                    string flp = Path.Combine(_env.WebRootPath, ConfigClass.FileFolder);
                    List<string>names = await _help.CopyFiles(files, flp,_env);
                    var atc = from at in names select (new AtachFiles() 
                    { 
                        FileName = at
                    });
                    vcs.AttachFiles.AddRange(atc);
                }
                vcs.Image = ConfigClass.VacancyImage;
                await _db.Vacancies.AddAsync(vcs);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vcs);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                throw new Exception("the id for vacancy can't be null");
            }
            Vacancy vc = await _db.Vacancies.Include(v => v.AttachFiles)
                .FirstOrDefaultAsync(v => v.id == id);
            if (vc == null)
                throw new Exception("the vacancy for to edit can't be null");
            return View(vc);
        }
        [HttpPost]
        public async Task<IActionResult>Edit(Vacancy vc, List<IFormFile> files,
            bool dlallfls
            )
        {
            if (ModelState.IsValid)
            {
                Vacancy vcc = await _db.Vacancies
                    .Include(v => v.AttachFiles)
                    .FirstOrDefaultAsync(v => v.id == vc.id);
                
                if (dlallfls)
                {
                    string flp = Path.Combine(_env.WebRootPath, ConfigClass.FileFolder);
                    foreach(var at in vcc.AttachFiles)
                    {
                        _help.DelteImg(at.FileName, flp);
                    }
                    vcc.AttachFiles.Clear();
                }
                if(files.Count > 0)
                {
                    string flp = Path.Combine(_env.WebRootPath, ConfigClass.FileFolder);
                    var names = await _help.CopyFiles(files, flp,_env);
                    var atf = from s in names select(new AtachFiles()
                    {
                        FileName = s
                    });
                    vcc.AttachFiles.AddRange(atf);
                }
                vcc.Title = vc.Title;
                vcc.Description = vc.Description;
                vcc.Text = vc.Text;
                vcc.PostedDate = vc.PostedDate;
                _db.Vacancies.Update(vcc);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vc);
        }
        [Route("api/vacancy/delete")]
        [HttpDelete]
        public async Task<IActionResult>Delete(int? id)
        {
            if (id == null)
                throw new Exception("the id for vacancy can't be null");
            Vacancy vc = await _db.Vacancies.Include(v => v.AttachFiles)
                .FirstOrDefaultAsync(v => v.id == id);
            if(vc == null)
            {
                throw new Exception("The vacancy for to delete can't be null");
            }
            if(vc.AttachFiles.Count > 0) 
            {
                var flp = Path.Combine(_env.WebRootPath, ConfigClass.FileFolder);
                foreach(AtachFiles at in vc.AttachFiles)
                {
                    AtachFiles tmp = await _db.AtachFiles.FindAsync(at.id);
                    _db.AtachFiles.Remove(tmp);
                    _help.DelteImg(at.FileName,flp);
                }
                vc.AttachFiles.Clear();
            }
            _db.Vacancies.Remove(vc);
            await _db.SaveChangesAsync();
            return Json(new { msg = "success" });
        }
    }
}
