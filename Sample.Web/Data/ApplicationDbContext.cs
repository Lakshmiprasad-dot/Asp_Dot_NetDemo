using Sample.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Sample.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}



