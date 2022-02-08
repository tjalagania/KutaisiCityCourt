using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models.ViewModels
{
    public class StructAndOtherFilesViewModel
    {
        public Struct Struct { get; set; }
        public AboutAtachFiles AbAtachFile { get; set; }
        public List<AboutAtachFiles> AbAtachFiles { get; set; } = new List<AboutAtachFiles>();
    }
}
