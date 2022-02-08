using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class Worker: Person
    {
        [EmailAddress(ErrorMessage = "არასწორი მაილის ფორმა")]
        public string Emal { get; set; }
        public virtual Position Position { get; set; }
        public virtual Judge Judge { get; set; }
    }
}
