using Microsoft.EntityFrameworkCore;

namespace Poudlard.Infrastructure.Database.Context;

public class PoudlardContext : DbContext
{
    public PoudlardContext(DbContextOptions options) : base(options)
    {
    }

    protected PoudlardContext()
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PoudlardContext).Assembly);
    }
}
