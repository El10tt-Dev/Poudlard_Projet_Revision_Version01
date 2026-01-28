using Microsoft.EntityFrameworkCore;
using Poudlard.Domain.Entities;

namespace Poudlard.Infrastructure.Database.Context;

public class PoudlardContext : DbContext
{
    public PoudlardContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Eleve> Eleves  { get; set; }
    public DbSet<Professeur> Professeurs { get; set; }
    public DbSet<Moldu> Moldus { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PoudlardContext).Assembly);
    }
}
