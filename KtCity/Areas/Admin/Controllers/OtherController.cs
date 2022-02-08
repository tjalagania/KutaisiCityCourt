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
    public class OtherController : Controller
    {
        private readonly KcDbContext _db;
        private readonly CiteHelper _help;
        private readonly IWebHostEnvironment _env;
        public OtherController(KcDbContext db,CiteHelper help,IWebHostEnvironment env)
        {
            _db = db;
            _help = help;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            StructAndOtherFilesViewModel stw = new StructAndOtherFilesViewModel();
            stw.AbAtachFiles = await _db.AboutAtachFiles.ToListAsync();
            Struct st;
            try
            {
                st = await _db.Structura.FirstAsync();
            }
            catch(Exception ex)
            {
                st = new Struct();
            }
            stw.Struct = st;
            return View(stw);
        }
        public async Task<IActionResult> CreateStruct(StructAndOtherFilesViewModel st)
        {
            if(ModelState.IsValid)
            {
                Struct stt = await _db.Structura.FindAsync(st.Struct.id);
                if(stt == null)
                {
                    await _db.Structura.AddAsync(st.Struct);
                    await _db.SaveChangesAsync();
                    
                }
                else
                {
                    stt.StaticText = st.Struct.StaticText;
                    _db.Structura.Update(stt);
                    await _db.SaveChangesAsync();
                    
                }
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> CreateFile(StructAndOtherFilesViewModel str,IFormFile file)
        {
            if (ModelState.IsValid)
            {

                if(file != null)
                {
                    string flp = Path.Combine(_env.WebRootPath, ConfigClass.FileFolder);
                    string flname = await _help.CopyFile(file, flp, _env);
                    str.AbAtachFile.FileName = flname;
                }
                await _db.AboutAtachFiles.AddAsync(str.AbAtachFile);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
