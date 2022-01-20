using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ienei_Csongor_Attila_Proiect_ASP_NET.Models;

namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Pages.CarsPage
{
    public class EditModel : PageModel
    {
        private readonly Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Ienei_Csongor_Attila_Proiect_ASP_NETContext _context;

        public EditModel(Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Ienei_Csongor_Attila_Proiect_ASP_NETContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["Dealershipid"] = new SelectList(_context.Dealership, "ID", "ID");
           ViewData["SalesID"] = new SelectList(_context.Sales, "ID", "ID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cars).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarsExists(Cars.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CarsExists(int id)
        {
            return _context.Cars.Any(e => e.ID == id);
        }
    }
}
