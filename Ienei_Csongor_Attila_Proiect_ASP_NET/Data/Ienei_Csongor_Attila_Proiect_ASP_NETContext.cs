using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ienei_Csongor_Attila_Proiect_ASP_NET.Models;

namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Models
{
    public class Ienei_Csongor_Attila_Proiect_ASP_NETContext : DbContext
    {
        public Ienei_Csongor_Attila_Proiect_ASP_NETContext (DbContextOptions<Ienei_Csongor_Attila_Proiect_ASP_NETContext> options)
            : base(options)
        {
        }

        public DbSet<Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Cars> Cars { get; set; }

        public DbSet<Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Dealership> Dealership { get; set; }

        public DbSet<Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Sales> Sales { get; set; }
    }
}
