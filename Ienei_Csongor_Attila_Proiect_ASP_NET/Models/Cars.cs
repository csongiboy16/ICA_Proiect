using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Models
{
    public class Cars
    {

        public int ID { get; set; }

        [Display(Name = "Car Brand")]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Brand { get; set; }

        [Display(Name = "Car Model")]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Model { get; set; }

        [Display(Name = "Production Date")]
        [DataType(DataType.Date)]
        public DateTime ProdDate { get; set; }

        [Display(Name = "Salesman ID")]
        [Required]
        public int SalesID { get; set; }
        public Sales Sales { get; set; }

        [Display(Name = "Dealership ID")]
        [Required]
        public int Dealershipid { get; set; }
        public Dealership Dealership { get; set; }


    }
}