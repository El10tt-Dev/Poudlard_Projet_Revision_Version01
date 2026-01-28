using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poudlard.Domain.Entities;
using Poudlard.Domain.Enums;

namespace Poudlard.Infrastructure.Database.Configuration;

internal class SorcierConfiguration : IEntityTypeConfiguration<Sorcier>
{
    public void Configure(EntityTypeBuilder<Sorcier> builder)
    {
        builder.Property(s => s.Baguette)
            .HasConversion<string>()
            .IsRequired()
            .HasDefaultValue(EssenceBaguette.NON_RENSEIGNEE);
        builder.Property(s => s.FideleVoldemort)
            .HasDefaultValue(false);
        builder.Property(s => s.PeutEntrerPoudlard)
            .HasDefaultValue(false);
    }
}
