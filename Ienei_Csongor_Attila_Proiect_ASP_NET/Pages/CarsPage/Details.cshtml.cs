using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ienei_Csongor_Attila_Proiect_ASP_NET.Models;

namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Pages.CarsPage
{
    public class DetailsModel : PageModel
    {
        private readonly Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Ienei_Csongor_Attila_Proiect_ASP_NETContext _context;

        public DetailsModel(Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Ienei_Csongor_Attila_Proiect_ASP_NETContext context)
        {
            _context = context;
        }

        public Cars Cars { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cars = await _context.Cars
                .Include(c => c.Dealership)
                .Include(c => c.Sales).FirstOrDefaultAsync(m => m.ID == id);

            if (Cars == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
