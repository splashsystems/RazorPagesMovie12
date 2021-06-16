using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie12.Models;

namespace RazorPagesMovie12.Data
{
    public class RazorPagesMovie12Context : DbContext
    {
        public RazorPagesMovie12Context (DbContextOptions<RazorPagesMovie12Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie12.Models.Movie> Movie { get; set; }
    }
}
