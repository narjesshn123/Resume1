using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resume1.Models;

namespace Resume1.Mapping;
public class WorkExperienceMapping : IEntityTypeConfiguration<WorkExperience>
{
    public void Configure(EntityTypeBuilder<WorkExperience> builder)
    {
        builder.ToTable("WorkExperiences");  
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Person).WithMany(x => x.WorkExperiences).HasForeignKey(x => x.PersonId);  
    }
}

