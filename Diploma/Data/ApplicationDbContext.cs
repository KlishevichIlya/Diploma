using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Diploma.Models;

namespace Diploma.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<News> News { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<Diploma.Models.Subject> Subject { get; set; }
        
    }
}
