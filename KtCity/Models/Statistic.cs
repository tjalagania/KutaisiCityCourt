using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class Statistic
    {
        [Key]
        public int id { get; set; }
        [DefaultValue("statistic")]
        [Required(ErrorMessage = "შეიყვანეთ სტატისტიკა")]
        [Display(Name = "სტატისტიკა")]
        public string StaticText { get; set; } = "statistic";
    }
}
