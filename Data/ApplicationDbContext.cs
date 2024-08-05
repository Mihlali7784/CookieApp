using CookieWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace CookieWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        
       public DbSet<Order> orders {  get; set; }
    }
}
