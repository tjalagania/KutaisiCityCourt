using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models.ViewModels
{
    public class MainJudgeViewModel
    {
        public Judge Chairman { get; set; }
        public List<Judge> Judges { get; set; }
    }
}
