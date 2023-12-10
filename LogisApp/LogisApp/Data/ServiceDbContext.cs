using LogisApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LogisApp.Data
{
    public class ServiceDbContext : DbContext
    {
        public ServiceDbContext(DbContextOptions<ServiceDbContext> options) :base(options   )
        {
          
        }
        public DbSet<Service> Services { get; set; }    
    }
}
