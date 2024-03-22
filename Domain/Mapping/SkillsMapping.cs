using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resume1.Models;

namespace Resume1.Mapping;
public class SkillsMapping : IEntityTypeConfiguration<Skills>
{
    public void Configure(EntityTypeBuilder<Skills> builder)
    {
        builder.ToTable("Skills");
        builder.HasKey(x => x.Id);

    }
}
