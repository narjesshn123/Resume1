using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Resume1.Models;

namespace Resume1.Mapping;
public class PersonLanguagesMapping : IEntityTypeConfiguration<PersonLanguages>
{
    public void Configure(EntityTypeBuilder<PersonLanguages> builder)
    {
        builder.ToTable("PersonLanguages");
        builder.HasKey(x => new { x.PersonId, x.LanguageId });  
        builder.HasOne(x=>x.Person).WithMany(x=>x.PersonLanguages).HasForeignKey(x=>x.PersonId);
        builder.HasOne(x => x.Languages).WithMany(x => x.PersonLanguages).HasForeignKey(x => x.LanguageId);                         
    }
}

