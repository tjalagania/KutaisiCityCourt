using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class NewsItem
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "სათაური სავალდებულოა")]
        [Display(Name = "სათაური")]
        public string Title { get; set; }
        [Required(ErrorMessage = "მოკლე აღწერა სავალდებულოა")]
        [Display(Name = "მოკლე აღწერა")]
        public string Description { get; set; }
        //[Required(ErrorMessage = "მიატვირთეთ სურათი")]
        public string Image { get; set; }
        [Required(ErrorMessage = "დასვით თარიღი")]
        [Display(Name ="თარიღი")]
        public string PostedDate { get; set; }
        [Required(ErrorMessage = "შეიყვანეთ ტექსტი")]
        [Display(Name ="ძირითადი ტექსტი")]
        public string Text { get; set; }
        public virtual List<AtachFiles> AttachFiles { get; set; } = new List<AtachFiles>();
    }
}
