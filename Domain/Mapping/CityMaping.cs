using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resume1.Models;

namespace Resume1.Mapping
{
    public class CityMaping : IEntityTypeConfiguration<City>
    {
        void IEntityTypeConfiguration<City>.Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City");
            builder.HasKey(x => x.Id);                                    
            builder.HasMany(x => x.persons).WithOne(x => x.City).HasForeignKey(x=>x.CityId);  

            
        }
    }
}
