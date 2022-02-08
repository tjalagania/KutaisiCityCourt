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
    public class NewsController : Controller
    {
        private readonly KcDbContext _db;
        private readonly CiteHelper _help;
        private readonly IWebHostEnvironment _env;
        public NewsController(KcDbContext db, CiteHelper help,
            IWebHostEnvironment env
            )
        {
            _db = db;
            _help = help;
            _env = env;
        }
        public async Task<IActionResult> Index(int p = 0,int s = 40)
        {
            if (p > 0)
            {
                p--;
            }
            ViewBag.AllCount = await _db.News.CountAsync();
            List<NewsItem> news = new List<NewsItem>();
            news.AddRange(await _db.News.OrderByDescending(nw => nw.id).Skip(p * s).Take(s).ToListAsync());
            return View(news);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(News nw,
            IFormFile img, List<IFormFile> files)
        {
            
                

            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    string imgpath = Path.Combine(_env.WebRootPath, ConfigClass.ImageFolder);
                    nw.Image = await _help.CopyFile(img, imgpath, _env);
                }
                if (files.Count > 0)
                {
                   string flpth = Path.Combine(_env.WebRootPath, ConfigClass.FileFolder);
                   List<string> fls = await _help.CopyFiles(files, flpth, _env);
                   foreach(var f in fls)
                    {
                        AtachFiles atf = new AtachFiles()
                        {
                            FileName = f
                        };
                        nw.AttachFiles.Add(atf);
                    }
                }
                
                await _db.News.AddAsync(nw);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
                
                //string flname = await _help.CopyFile(img, imgp, _env);
               
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult>Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            News nw = await _db.News.FindAsync(id);
            if (nw == null)
                return NotFound();
            return View(nw);
        }
        private void deleteAtachFiles(List<AtachFiles> atachf)
        {
            foreach (var atf in atachf)
            {
                _help.DelteImg(atf.FileName,
                Path.Combine(_env.WebRootPath, ConfigClass.FileFolder));
            }
        }
        private List<AtachFiles> AtachfileList(List<string> names)
        {
            List<AtachFiles> tmplist = new List<AtachFiles>();
            foreach (var f in names)
            {
                AtachFiles atf = new AtachFiles()
                {
                    FileName = f
                };
                tmplist.Add(atf);
            }
            return tmplist;
        }
       
        [HttpPost]
        public async Task<IActionResult> Edit(News nw,
            IFormFile img, List<IFormFile> files,bool dlallfls)
        {
            if (ModelState.IsValid)
            {
                News tmpnews = await _db.News.Include(m => m.AttachFiles)
                    .FirstOrDefaultAsync(m => m.id == nw.id);
                tmpnews.Title = nw.Title;
                tmpnews.Description = nw.Description;
                tmpnews.PostedDate = nw.PostedDate;
                if (dlallfls)
                {
                    deleteAtachFiles(tmpnews.AttachFiles);
                    tmpnews.AttachFiles.Clear();
                }
                if (img != null)
                {
                    if (!string.IsNullOrEmpty(tmpnews.Image))
                    {
                        _help.DelteImg(tmpnews.Image, 
                            Path.Combine(_env.WebRootPath, ConfigClass.ImageFolder));
                    }
                    string imgpath = Path.Combine(_env.WebRootPath, ConfigClass.ImageFolder);
                    tmpnews.Image = await _help.CopyFile(img, imgpath, _env);
                }
                if (files.Count > 0)
                {
                      string flpth = Path.Combine(_env.WebRootPath, ConfigClass.FileFolder);
                      List<string> fls = await _help.CopyFiles(files, flpth, _env);
                      tmpnews.AttachFiles.AddRange(AtachfileList(fls));
                }
                _db.News.Update(tmpnews);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [Route("api/news/delete")]
        [HttpDelete]
        public async Task<IActionResult>Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            News nw = await _db.News.Include(m => m.AttachFiles)
                    .FirstOrDefaultAsync(m => m.id == id);
            if (nw == null)
                return NotFound();
            deleteAtachFiles(nw.AttachFiles);
            nw.AttachFiles.Clear();
            if (!string.IsNullOrEmpty(nw.Image))
                _help.DelteImg(nw.Image, Path.Combine(_env.WebRootPath, "img"));
            _db.News.Remove(nw);
            await _db.SaveChangesAsync();
            return Json(new { msg = "success" });
        }
    }
}
