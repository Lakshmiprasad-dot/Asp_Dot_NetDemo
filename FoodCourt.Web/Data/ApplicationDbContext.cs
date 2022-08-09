using FoodCourt.Web.Models;
using Microsoft.EntityFrameworkCore;
namespace FoodCourt.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }

        public DbSet<FoodCourt.Web.Models.Order> Order { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        
    }
}
