using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models.ViewModels
{
    public class PalatAndPalatsList
    {
        public Palats Palat { get; set;}
        public List<Palats> PalatList { get; set; } = new List<Palats>();
    }
}
