using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resume1.Models;

namespace Resume1.Mapping;
public class PersonSkillsMapping : IEntityTypeConfiguration<PersonSkills>
{
    public void Configure(EntityTypeBuilder<PersonSkills> builder)
    {
        builder.ToTable("PersonSkills");  
        builder.HasKey(x => new { x.PersonId, x.SkillId });
        builder.HasOne(x => x.Person).WithMany(x => x.PersonSkills).HasForeignKey(x => x.PersonId);
        builder.HasOne(x => x.Skills).WithMany(x => x.PersonSkills).HasForeignKey(x => x.SkillId);                         
    }
}
