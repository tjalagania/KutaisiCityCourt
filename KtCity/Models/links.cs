using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class links
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "დასახელება სავალდებულოა")]
        [Display(Name = "ბმულის დასახელება")]
        public string Text { get; set; }
        [Required(ErrorMessage = "მიუთითეთ მისამართი")]
        [Display(Name = "ბმულის მისმართი")]
        public string Link { get; set; }
        [DefaultValue(true)]
        [Required(ErrorMessage = "მიუთითეთ რიგი სიაში")]
        [Display(Name = "რიგობითი ნომერი სიაში")]
        public int PositinInLink { get; set; } = 1;
    }
}
