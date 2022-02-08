using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models.ViewModels
{
    public class JudgeViewModel
    {
        public Judge Judge { get; set; }
        public List<Palats> Palats { get; set; } = new List<Palats>();
        public List<Worker> Workers { get; set; } = new List<Worker>();
    }
}
