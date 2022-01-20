using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Models
{
    public class Dealership
    {
        public int ID { get; set; }
        [Display(Name = "Dealership's Name")]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string DealershipName { get; set; }
        public ICollection<CarDealership> CarDealership { get; set; }
    }
}