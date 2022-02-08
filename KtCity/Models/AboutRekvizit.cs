using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class AboutRekvizit
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "მიუთითეთ რეკვიზიტი")]
        [Display(Name = "რეკვიზიტი")]
        public string Text { get; set; }
        public virtual About About { get; set; }
        
        
    }
}
