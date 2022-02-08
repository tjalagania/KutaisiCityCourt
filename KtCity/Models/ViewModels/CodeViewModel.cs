using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models.ViewModels
{
    public class CodeViewModel
    {
        public Cods Code { get; set; }
        public List<Cods> Codes { get; set; } = new List<Cods>();
    }
}
