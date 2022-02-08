using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class GaleryImgs
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "სურათი")]
        public string ImgName { get; set; }
        public virtual Galery Galery { get; set; }
    }
}
