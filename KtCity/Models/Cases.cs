using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class Cases
    {
        public string refreshValue { get; set; }
        public string Dt { get; set; }
        public string draw { get; set; }
        public string recordsTotal { get; set; }
        public string recordsFiltered { get; set; }
        public CaseData[] data { get; set; }
    }
}
