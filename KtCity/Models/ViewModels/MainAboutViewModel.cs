using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models.ViewModels
{
    public class MainAboutViewModel
    {
        public List<About> Abouts { get; set; } = new List<About>();
        public Struct Struct { get; set; }
        public List<AboutAtachFiles> Files { get; set; } = new List<AboutAtachFiles>();
    }
}
