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
    public class ComandController : Controller
    {
        private readonly KcDbContext _db;
        private readonly CiteHelper _help;
        private readonly IWebHostEnvironment _env;
        public ComandController(KcDbContext db,
            CiteHelper help, IWebHostEnvironment env
            )
        {
            _db = db;
            _help = help;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            var commands = await _db.Commands.ToListAsync();
            return View(commands);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        private async void CopyFs(Commands cm, List<IFormFile> fl)
        {
            
                string flp = Path.Combine(_env.WebRootPath, ConfigClass.FileFolder);
                var flnames = await _help.CopyFiles(fl, flp, _env);
                foreach (string s in flnames)
                {
                    cm.AttachFiles.Add(new AtachFiles()
                    {
                        FileName = s

                    });
                }
        }
        [HttpPost]
        public async Task<IActionResult>Create(Commands cm, List<IFormFile>files)
        {
            if (ModelState.IsValid)
            {
                cm.Image = ConfigClass.JudgeHummer;
                if(files.Count > 0)
                {
                    CopyFs(cm, files);
                    //string flp = Path.Combine(_env.WebRootPath, ConfigClass.FileFolder);
                    //var flnames = await _help.CopyFiles(files, flp, _env);
                    //foreach(string s in flnames)
                    //{
                    //    cm.AttachFiles.Add(new AtachFiles()
                    //    {
                    //        FileName = s
                           
                    //    });
                    //}
                }
                await _db.Commands.AddAsync(cm);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cm);
        }
        [HttpGet]
        public async Task<IActionResult>Edit(int? id)
        {
            if(id == null)
                throw new Exception("The id isn't null");
            Commands cm = await _db.Commands.FindAsync(id);
            if (cm == null)
                throw new Exception("the command not found");
            return View(cm);
        }
        [HttpPost]
        public async Task<IActionResult>Edit(Commands cm, List<IFormFile> files,bool dlallfls)
        {
            if (ModelState.IsValid)
            {
                Commands cmtmp = await _db.Commands.Include(m => m.AttachFiles)
                    .FirstOrDefaultAsync(m => m.id == cm.id);
                if(cmtmp == null)
                {
                    throw new Exception("commands not found for edit");
                }
                if (dlallfls)
                {
                    string flpath = Path.Combine(_env.WebRootPath, ConfigClass.FileFolder);
                    foreach(AtachFiles atf in cmtmp.AttachFiles)
                    {
                        _help.DelteImg(atf.FileName, flpath);
                        
                    }
                    cmtmp.AttachFiles.Clear();
                }
                if (files.Count > 0)
                {
                    CopyFs(cm, files);
                }
                cmtmp.Title = cm.Title;
                cmtmp.Description = cm.Description;
                cmtmp.PostedDate = cm.PostedDate;
                cmtmp.Text = cm.Text;

                _db.Commands.Update(cmtmp);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cm);
        }
        [Route("api/command/delete")]
        [HttpDelete]
        public async Task<IActionResult>Delete(int? id)
        {
            if (id == null)
                throw new Exception("the id of comand don't be null");
            Commands cm = await _db.Commands
                .Include(m => m.AttachFiles)
                .FirstOrDefaultAsync(m => m.id == id);
            if (cm == null)
                throw new Exception("the command can't find for to delete");

            if(cm.AttachFiles !=null && cm.AttachFiles.Count > 0)
            {
                string flp = Path.Combine(_env.WebRootPath, ConfigClass.FileFolder);
                foreach(AtachFiles at in cm.AttachFiles)
                {
                    AtachFiles atf = await _db.AtachFiles.FindAsync(at.id);
                    _db.AtachFiles.Remove(atf);
                    _help.DelteImg(at.FileName, flp);
                }
                cm.AttachFiles.Clear();
            }
            _db.Commands.Remove(cm);
            await _db.SaveChangesAsync();

            return Json(new { msg = "success" });
        }
        
    }
}
