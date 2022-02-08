using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models.ViewModels
{
    public class WorkerViewModel
    {
        public Worker Worker { get; set; }
        public List<Position>Positions { get; set; }
    }
}
