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
    public class CodeController : Controller
    {
        private readonly KcDbContext _db;
        public CodeController(KcDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult>Create(CodeViewModel cdw)
        {
            if (ModelState.IsValid)
            {
                await _db.Codes.AddAsync(cdw.Code);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cdw);
        }
        public async Task<IActionResult> IndexAsync()
        {
            CodeViewModel cdw = new CodeViewModel();
            cdw.Codes = await _db.Codes.ToListAsync();
            return View(cdw);
        }
        [HttpGet]
        public async Task<IActionResult>Edit(int id)
        {
            Cods cds = await _db.Codes.FindAsync(id);
            if(cds == null)
            {
                throw new Exception("the codes not found for id");
            }

            return View(cds);
        }
        [HttpPost]
        public async Task<IActionResult>Edit(Cods cds)
        {
            if (ModelState.IsValid)
            {
                Cods cdtmp = await _db.Codes.FindAsync(cds.id);
                if (cdtmp == null)
                    throw new Exception("the code can't be null");
                cdtmp.CodeName = cds.CodeName;
                cdtmp.CodeNumber = cds.CodeNumber;
                _db.Codes.Update(cdtmp);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cds);
        }
        [Route("api/code/delete")]
        [HttpDelete]
        public async Task<IActionResult>Delete(int? id)
        {
            if (id == null)
                throw new Exception("the id for code can't be null");
            Cods cds = await _db.Codes.FindAsync(id);
            if (cds == null)
                throw new Exception("the code for to delete can't be null");

            _db.Codes.Remove(cds);
            await _db.SaveChangesAsync();
            return Json(new { msg = "success" });
        }
    }
}
