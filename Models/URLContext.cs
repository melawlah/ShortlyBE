using Microsoft.EntityFrameworkCore;

namespace ShortlyBE.Models
{
    public class URLContext : DbContext
    {
        public URLContext(DbContextOptions<URLContext> options)
            : base(options)
        {
        }

        public DbSet<GeneratedURLs> GeneratedURL { get; set; }
    }
}

