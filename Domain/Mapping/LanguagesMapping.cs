using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resume1.Models;

namespace Resume1.Mapping;
public class LanguagesMapping : IEntityTypeConfiguration<Languages>
{
    public void Configure(EntityTypeBuilder<Languages> builder)
    {
        builder.ToTable("Languages");
        builder.HasKey(x => x.Id);

    } 
}
