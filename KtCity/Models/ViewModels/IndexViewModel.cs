using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models.ViewModels
{
    public class IndexViewModel
    {
        public About Abuot { get; set; }
        public List<News> News { get; set; } = new List<News>();
        public CaseData[] CaseData { get; set; }
    }
}
