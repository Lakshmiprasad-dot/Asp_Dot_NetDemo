using Asp_Dot_NetDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp_Dot_NetDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
          
        }
    }
}
