using Microsoft.EntityFrameworkCore;
using vega.Model;

namespace vega.Persistence
{
    public class VegaDbContext : DbContext
    {
       public VegaDbContext(DbContextOptions<VegaDbContext> options)
       : base(options)
       { 

       } 

        public DbSet<Make> Makes { get; set; }

    }
}