using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using System.Globalization;
using Microsoft.AspNetCore.Http;

namespace KtCity.Models
{
    public class CiteHelper
    {
        private IWebHostEnvironment _env;

        private readonly IConfiguration _config;

        public string Images => _config["CiteConfig:img"].Trim();
        public string NoImage => _config["CiteConfig:noimage"].Trim();
        public CiteHelper(IConfiguration confing)
        {
            _config = confing;

        }
        public string ImagePath(string imagename,IWebHostEnvironment env)
        {
            if (imagename == null)
                imagename = NoImage;
            string imagecheck = Path.Combine(env.WebRootPath,Images, imagename);
            if (!File.Exists(imagecheck))
            {
                return $"/{Images}/{NoImage}";
            }
            return $"/{Images}/{imagename}";
        }
        public async Task<List<string>>CopyFiles(List<IFormFile>files,string path, 
            IWebHostEnvironment env)
        {
            List<string> filenames = new List<string>();
            if (files.Count == 0)
                throw new Exception("Files not send");

            _env = env;
            string flname = "";
            foreach(var file in files)
            {
                string flpath = Path.Combine(path, file.FileName);
                using(var stream = System.IO.File.Create(flpath))
                {
                    await file.CopyToAsync(stream);
                }
                flname = await RenameFile(flpath,env,path);
                filenames.Add(flname);
            }
            return filenames;

        }
        public async Task<string> CopyFile(IFormFile file,string path,IWebHostEnvironment env)
        {
            _env = env;
            if (file == null)
                throw new Exception("file not send");
            string imgName = "";
            if (file != null)
            {
                string imgpp = Path.Combine(path, file.FileName);
                using (var stream = System.IO.File.Create(imgpp))
                {
                    await file.CopyToAsync(stream);

                }
                imgName = await RenameFile(imgpp, _env, path);
            }
            return imgName;
        }
        public async Task<string> RenameFile(string filename, IWebHostEnvironment env,string path)
        {
            
            _env = env;

            FileInfo fl = new(filename);
            string name = (DateTime.Now.Ticks-5_000_000_000_000_000_00).ToString();
            string flname = Path.Combine(_env.WebRootPath,path,$"{name}{fl.Extension}");
            System.IO.File.Move(filename, flname);
            return $"{name}{fl.Extension}";
        }
        public void DelteImg(string filename,string directoryFullname)
        {


            if (filename != null && directoryFullname != null)
            {
                string flname = System.IO.Path.Combine(directoryFullname, filename);
                if (System.IO.File.Exists(flname))
                {
                    System.IO.File.Delete(flname);
                }
            }
            else
                throw new Exception("ფაილი ან საქაღალდე მითითებული არაა");

        }
        public string FormatDate(string date)
        {
            DateTime dt = DateTime.Parse(date);
            return dt.ToString("d", new CultureInfo("de-DE"));
        }
    }

}
