using ghEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace ghEntities
{
    public class ghRepositoryContext : DbContext
    {
        public ghRepositoryContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<ghArchive> ghArchives { get; set; }
    }
}
