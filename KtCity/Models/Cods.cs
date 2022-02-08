using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class Cods
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "მიუთითეთ კოდის დანიშნულება")]
        [Display(Name = "დანიშნულება")]
        public string CodeName { get; set; }
        [Required(ErrorMessage = "მიუთითეთ კოდი")]
        [Display (Name = "კოდი")]
        public string CodeNumber { get; set; }
        [Required(ErrorMessage = "მიუთითეთ პოზიცია სიაშია")]
        [Display(Name = "პოზიცია სიაში")]
        public int PositionInList { get; set; }
    }
}
