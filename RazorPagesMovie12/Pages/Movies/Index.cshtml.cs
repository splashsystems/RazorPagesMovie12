﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie12.Data;
using RazorPagesMovie12.Models;

namespace RazorPagesMovie12.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie12.Data.RazorPagesMovie12Context _context;

        public IndexModel(RazorPagesMovie12.Data.RazorPagesMovie12Context context)
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