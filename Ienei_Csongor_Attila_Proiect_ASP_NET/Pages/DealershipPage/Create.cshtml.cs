using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ienei_Csongor_Attila_Proiect_ASP_NET.Models;

namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Pages.DealershipPage
{
    public class CreateModel : PageModel
    {
        private readonly Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Ienei_Csongor_Attila_Proiect_ASP_NETContext _context;

        public CreateModel(Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Ienei_Csongor_Attila_Proiect_ASP_NETContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Dealership Dealership { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Dealership.Add(Dealership);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}