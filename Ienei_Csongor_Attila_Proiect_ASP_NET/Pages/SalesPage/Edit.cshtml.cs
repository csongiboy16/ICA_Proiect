﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ienei_Csongor_Attila_Proiect_ASP_NET.Models;

namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Pages.SalesPage
{
    public class EditModel : PageModel
    {
        private readonly Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Ienei_Csongor_Attila_Proiect_ASP_NETContext _context;

        public EditModel(Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Ienei_Csongor_Attila_Proiect_ASP_NETContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sales Sales { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sales = await _context.Sales.FirstOrDefaultAsync(m => m.ID == id);

            if (Sales == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sales).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesExists(Sales.ID))
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

        private bool SalesExists(int id)
        {
            return _context.Sales.Any(e => e.ID == id);
        }
    }
}
