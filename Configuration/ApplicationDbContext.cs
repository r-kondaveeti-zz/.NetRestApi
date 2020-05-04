using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Configuration {

    public class ApplicationDbContext : DbContext {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        
    }
}