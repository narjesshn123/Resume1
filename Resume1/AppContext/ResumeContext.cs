using Microsoft.EntityFrameworkCore;
using Resume1.Mapping;
using Resume1.Models;

namespace Resume1.AppContext
{
    public class ResumeContext : DbContext
    {
        public ResumeContext(DbContextOptions<ResumeContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonMapping());                  
            modelBuilder.ApplyConfiguration(new CityMaping()); 
            modelBuilder.ApplyConfiguration(new LanguagesMapping()); 
            modelBuilder.ApplyConfiguration(new PersonLanguagesMapping());
            modelBuilder.ApplyConfiguration(new SkillsMapping());
            modelBuilder.ApplyConfiguration(new PersonSkillsMapping());
            modelBuilder.ApplyConfiguration(new WorkExperienceMapping());                      
            base.OnModelCreating(modelBuilder); 
        }

    

        public DbSet<Person> Person { get; set; }  
        public DbSet<City> Cities { get; set; }  
        public DbSet<Languages> Languages { get; set; }                                                     
        public DbSet<PersonLanguages> PersonLanguages { get; set; }                                          
        public DbSet<Skills> Skills { get; set; }
        public DbSet<PersonSkills> PersonSkills { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }

    }

}
