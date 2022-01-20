using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ienei_Csongor_Attila_Proiect_ASP_NET.Models;

namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Pages.SalesPage
{
    public class IndexModel : PageModel
    {
        private readonly Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Ienei_Csongor_Attila_Proiect_ASP_NETContext _context;

        public IndexModel(Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Ienei_Csongor_Attila_Proiect_ASP_NETContext context)
        {
            _context = context;
        }

        public IList<Sales> Sales { get;set; }

        public async Task OnGetAsync()
        {
            Sales = await _context.Sales.ToListAsync();
        }
    }
}
