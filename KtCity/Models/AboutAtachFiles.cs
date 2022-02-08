using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class AboutAtachFiles
    {
        public int id { get; set; }
        public string FileName { get; set; }
        [Display(Name = "ფაილის აღწერა | სათაური")]
        public string Anotation { get; set; }
        public virtual links Links {get;set;}
    }
}
