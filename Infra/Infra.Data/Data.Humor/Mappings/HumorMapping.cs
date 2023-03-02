using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HumorDomain = Domain.Humor.Entities.Humor;

namespace Data.Humor.Mappings;

public class HumorMapping : IEntityTypeConfiguration<HumorDomain>
{
    public void Configure(EntityTypeBuilder<HumorDomain> builder)
    {
        builder.ToTable("Cat_Category", "Product");

        builder.HasKey(h => h.Id)
            .HasName("PK_Hum_Humor");
        builder.Property(h => h.Id)
            .HasColumnName("Hum_HumorId")
            .IsRequired();
        builder.Property(h => h.Title)
            .HasColumnName("Hum_Title")
            .IsRequired();
        builder.Property(h => h.Description)
            .HasColumnName("Hum_Description")
            .IsRequired();
        builder.Property(h => h.HumorType)
            .HasColumnName("Hum_HumorType")
            .IsRequired();
        builder.Property(h => h.IsVisible)
            .HasColumnName("Hum_IsVisible")
            .IsRequired();

        builder.Ignore(x => x.ValidationResult);
        builder.Ignore(x => x.ClassLevelCascadeMode);
        builder.Ignore(x => x.RuleLevelCascadeMode);
        builder.Ignore(x => x.CascadeMode);
    }
}