using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Models
{
    public class Sales
    {
        public int ID { get; set; }

        [Display(Name = "Salesman's Name")]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string SalesName { get; set; }

        public ICollection<Cars> Cars { get; set; } //navigation property
    }
}