using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models.ViewModels
{
    public class GaleryViewModel
    {
        public Galery Galery { get; set; }
        public List<Galery> Galeries { get; set; } = new List<Galery>();
        
    }
}
