using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class Galery
    {
        public int id { get; set; }
        [Required(ErrorMessage = "სახელი სავალდებულოა")]
        [Display(Name = "გალერიის დასახელბა")]
        public string Name { get; set; }
        public string Cover { get; set; }
        public virtual List<GaleryImgs>Images { get; set; }
    }
}
