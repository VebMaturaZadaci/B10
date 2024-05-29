using Microsoft.EntityFrameworkCore;

namespace B10.Data
{
    public class RecnikDbContext : DbContext
    {
        public RecnikDbContext(DbContextOptions<RecnikDbContext> options) : base(options)
        {
        }

        public DbSet<Prevod> Prevodi { get; set; }
    }
}
