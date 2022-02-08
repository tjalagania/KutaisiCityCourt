using KtCity.filters;
using KtCity.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Ad = KtCity.Models.Admin;
namespace KtCity.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class LoginController : Controller
    {
        private readonly KcDbContext _db;
        public LoginController(KcDbContext db)
        {
            _db = db;
        }
        [IPFilter()]
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> login(Ad admin)
        {
            Ad adm = await _db.Admin.FirstOrDefaultAsync(m => m.Login == admin.Login && m.Password == admin.Password);

            if (adm == null)
                return RedirectToAction(nameof(Index));

            await Authenticate(admin.Login);
            return RedirectToAction("Index", "Home");
        }
        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
