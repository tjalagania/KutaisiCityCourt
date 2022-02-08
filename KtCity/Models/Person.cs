using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class Person
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "სახელი სავალდებულოა")]
        [Display(Name = "სახელი")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "გვარი სავალდებულოა")]
        [Display(Name = "გვარი")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "მიუთითეთ დაბადების თარიღი")]
        [Display(Name = "დაბადების თარიღი")]
        public string Birthday { get; set; }
        [Required(ErrorMessage = "ბიოგრაფია სავალდებულოა")]
        [Display(Name = "ბიოგრაფია")]
        public string Biography { get; set; }
        public string Image { get; set; }
        public virtual void Copy(Person p)
        {
            FirstName = p.FirstName;
            LastName = p.LastName;
            Birthday = p.Birthday;
            Biography = p.Biography;
            
        }
    }
}
