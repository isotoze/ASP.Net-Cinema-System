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
    public class IndexModel : PageModel
    {
        private readonly ASPCinemaApplication.Data.ASPCinemaApplicationContext _context;

        public IndexModel(ASPCinemaApplication.Data.ASPCinemaApplicationContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
