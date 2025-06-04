using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LinkHub.Models;

namespace LinkHub.Data;

// The application's Entity Framework Core database context.
// Inherits from IdentityDbContext to include ASP.NET Core Identity tables.
public class ApplicationDbContext : IdentityDbContext
{
    // Constructor that passes options to the base IdentityDbContext.
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    // DbSet for storing LinkItem entities (bookmarks).
    public DbSet<LinkItem> LinkItems { get; set; }

}
