using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LinkHub.Data
{
    // This factory is used by EF Core tools at design time (e.g., for migrations)
    // to create an instance of ApplicationDbContext with the correct options.
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            // Configure the DbContext to use PostgreSQL for design-time operations
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=LinkHubDb;Username=postgres;Password=");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
