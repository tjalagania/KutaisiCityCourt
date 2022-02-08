using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models.ViewModels
{
    public class LinkViewModel
    {
        public links Link { get; set; }
        public List<links> Links { get; set; } = new List<links>();
    }
}
