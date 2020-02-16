using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPCinemaApplication.Data;
using ASPCinemaApplication.Models;

namespace ASPCinemaApplication.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly ASPCinemaApplication.Data.ASPCinemaApplicationContext _context;

        public DetailsModel(ASPCinemaApplication.Data.ASPCinemaApplicationContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
