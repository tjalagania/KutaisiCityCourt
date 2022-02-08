using KtCity.Models;
using KtCity.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace KtCity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;



        private readonly KcDbContext _db;
        public HomeController(ILogger<HomeController> logger,KcDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public async Task<IActionResult> Index(string dt = null)
        {
            IndexViewModel indw = new IndexViewModel();
            indw.Abuot = await _db.About.OrderBy(ab => ab.id).FirstAsync();
            indw.News = await _db.News.OrderByDescending(nw => nw.id).Take(3).ToListAsync();
            indw.CaseData = OnGetCases(dt);
            return View(indw);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public CaseData[] OnGetCases(string dt)
        {
            int law = 1;
            if (dt == null)
            {

                dt = "kutaisicrime";
            }
            switch (dt)
            {
                case "kutaisicivil":
                    law = 2;
                    break;
                case "kutaisiadministrative":
                    law = 3;
                    break;
                default:
                    law = 1;
                    dt = "kutaisicrime";
                    break;
            }
                CookieCollection Cookies;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create($"http://courtmonitor.court.gov.ge/{dt}");
                req.CookieContainer = new CookieContainer();
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                Cookies = resp.Cookies;
                req = (HttpWebRequest)WebRequest.Create($"http://courtmonitor.court.gov.ge/Home/GetTimetable1?law={law}");
                req.CookieContainer = new CookieContainer();
                req.CookieContainer.Add(new Cookie { Name = Cookies[0].Name, Value = Cookies[0].Value, Domain = "courtmonitor.court.gov.ge" });
                resp = (HttpWebResponse)req.GetResponse();

                Stream dataSt = resp.GetResponseStream();
                StreamReader rd = new StreamReader(dataSt);

                string respst = rd.ReadToEnd();

                //int data = respst.IndexOf(@"[");
                //str = respst.Substring(data);
                return ((Cases)JsonSerializer.Deserialize(respst, typeof(Cases))).data;
            

        }

        
    }
}
