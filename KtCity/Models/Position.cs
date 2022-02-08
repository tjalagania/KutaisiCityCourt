using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class Position
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name="დასახელება")]
        public string Name { get; set; }
        [Required]
        
        public int Rang { get; set; }
        public virtual List<Worker>Workers { get; set; }
    }
}
