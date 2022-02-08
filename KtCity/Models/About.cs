using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class About
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "მიუთითეთ სათაური")]
        [Display(Name = "სათაური")]
        public string Name { get; set; }
        [Required(ErrorMessage = "მიუთითეთ ტექსტი")]
        [Display(Name = "ძირითადი ტექსტი")]
        public string Text { get; set; }
        [Required(ErrorMessage = "მიუთითეთ ტექსტი")]
        [Display(Name = "მოკლე აღწერა")]
        public string Description { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "მიუთითეთ მისამართი")]
        [Display(Name = "მისამართი")]
        public string Address { get; set; }
        
        [Display(Name ="ტელეფონების სია (შეყვანა: 55555555;444444444;)")]
        public string RekviziteStrng { get; set; }
        
        [Display(Name = "ელექტრონული ფოსტა(E - mail)")]
        public string EmailString { get; set; }
        [Display(Name = "დამატებითი რეკვიზიტები")]
        public bool Tag { get; set; }
    }
}
