using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poudlard.Domain.Entities;
using Poudlard.Domain.Enums;

namespace Poudlard.Infrastructure.Database.Configuration;

internal class ProfesseurConfiguration : IEntityTypeConfiguration<Professeur>
{
    public void Configure(EntityTypeBuilder<Professeur> builder)
    {
        builder.Property(prof => prof.CourAttribue)
            .IsRequired()
            .HasMaxLength(150);
        builder.Property(prof => prof.ChefMaison)
            .HasDefaultValue(false);
        builder.Property(prof => prof.Maison)
            .HasConversion<string>()
            .HasDefaultValue(MaisonAttribuee.None);
    }
}
