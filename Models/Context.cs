using Microsoft.EntityFrameworkCore;
namespace Moviey_Back.Models
{
    public class Context :DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Watchlist> watchlists { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

    }
}
