using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poudlard.Domain.Entities;

namespace Poudlard.Infrastructure.Database.Configuration;

internal class PersonneConfiguration : IEntityTypeConfiguration<Personne>
{
    public void Configure(EntityTypeBuilder<Personne> builder)
    {
        builder.HasKey(pe  => pe.Id);

        builder.Property(pe => pe.Nom)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(pe => pe.Prenom)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(pe => pe.DateNaissance)
            .IsRequired();
    }
}
