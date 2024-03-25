using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Contracts.Person;                                          
    public class CreatePerson
    {
    public string Name { get; private set; }
    public string Family { get; private set; }
    public string? Email { get; private set; }
    public string? PhoneNumber { get; private set; }
    public bool Geger { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    //public Job Job { get; private set; }
    //public int JobId { get; private set; }
    //public List<EducationalRecord> EducationalRecords { get; private set; } = new List<EducationalRecord>();
    //public List<PersonLanguages> PersonLanguages { get; private set; } = new List<PersonLanguages>();
    //public List<WorkExperience> WorkExperiences { get; private set; } = new List<WorkExperience>();
    //public City City { get; private set; }
    //public int CityId { get; private set; }
    //public List<PersonSkills> PersonSkills { get; private set; } = new List<PersonSkills>();
}
