using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models.ViewModels
{
    public class MainWorkerViewModel
    {
        public Person Manager { get; set; }
        public List<Person> Workers { get; set; } = new List<Person>();
        public List<Person> FirstLine { get; set; } = new List<Person>();
        public List<Person> SecondLine { get; set; } = new List<Person>();
        public List<List<Person>> Persons { get; set; } = new List<List<Person>>();
        public int Lines { get; set; }
        public int PersoInLine { get; set; } = 8;
    }
}
