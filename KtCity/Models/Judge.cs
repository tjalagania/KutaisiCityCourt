using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KtCity.Models
{
    public class Judge: Person
    {
        [DefaultValue(true)]
        [Display(Name ="თავმჯდომარე")]
        public bool Chariman { get; set; } = false;
        public virtual Palats Position { get; set; }
        public virtual List<Worker>Aparati { get; set; }
        public override void Copy(Person p)
        {
            base.Copy(p);
            Chariman = ((Judge)p).Chariman;

        }
    }
}
