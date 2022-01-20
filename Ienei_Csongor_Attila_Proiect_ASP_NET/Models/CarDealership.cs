using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Models
{
    public class CarDealership
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public Cars Cars { get; set; }
        public int DealershipID { get; set; }
        public Dealership Dealership { get; set; }
    }
}