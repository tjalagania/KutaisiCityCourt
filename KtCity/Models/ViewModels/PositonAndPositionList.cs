using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models.ViewModels
{
    public class PositonAndPositionList
    {
        public Position Position { get; set; }
        public List<Position> PostionList { get; set; } = new List<Position>();
        
    }
}
