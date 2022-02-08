using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class Email
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "ელექტრონული ფოსტა (E-mail)")]
        [EmailAddress(ErrorMessage ="მაილის ფორმა არასწორია" )]
        public string EmailText { get; set; }
        public About About { get; set; }

    }
}
