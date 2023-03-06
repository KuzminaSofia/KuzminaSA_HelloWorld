using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KuzminaSA.Models;

namespace KuzminaSA.Data
{
    public class KuzminaSAContext : DbContext
    {
        public KuzminaSAContext (DbContextOptions<KuzminaSAContext> options)
            : base(options)
        {
        }

        public DbSet<KuzminaSA.Models.Movie> Movie { get; set; } = default!;
    }
}
