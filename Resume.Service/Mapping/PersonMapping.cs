﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resume1.Models;

namespace Resume1.Mapping;
public class PersonMapping : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("Persons");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(255).IsRequired();  
        builder.Property(x=>x.PhoneNumber).HasMaxLength(11).IsRequired();  
        builder.HasOne(x => x.City).WithMany(x => x.persons).HasForeignKey(x => x.CityId);
        builder.HasMany(x => x.WorkExperiences).WithOne(x => x.Person).HasForeignKey(x => x.PersonId);                 
    }
}
