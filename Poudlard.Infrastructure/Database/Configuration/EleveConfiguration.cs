using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poudlard.Domain.Entities;
using Poudlard.Domain.Enums;

namespace Poudlard.Infrastructure.Database.Configuration;

internal class EleveConfiguration : IEntityTypeConfiguration<Eleve>
{
    public void Configure(EntityTypeBuilder<Eleve> builder)
    {
        builder.Property(e => e.Annee)
            .IsRequired()
            .HasDefaultValue(AnneeEtude.PASCOMMENCE);
        builder.Property(e => e.Maison)
            .HasConversion<string>()
            .IsRequired()
            .HasDefaultValue(MaisonAttribuee.None);
    }
}
