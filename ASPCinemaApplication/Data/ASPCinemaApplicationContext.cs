using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPCinemaApplication.Models;

namespace ASPCinemaApplication.Data
{
    public class ASPCinemaApplicationContext : DbContext
    {
        public ASPCinemaApplicationContext (DbContextOptions<ASPCinemaApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<ASPCinemaApplication.Models.Movie> Movie { get; set; }
    }
}
