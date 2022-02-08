using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class Palats
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "მიუთითეთ პალატის სახელი")]
        [Display(Name = "სახელი")]
        public string Name { get; set; }
        [Required]
        [Display(Name="მიუთითეთ რანგი")]
        public int Rang { get; set; }
        public virtual List<Judge> Judges { get; set; }
    }
}
