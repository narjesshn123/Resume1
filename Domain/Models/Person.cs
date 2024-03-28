namespace Resume1.Models; 
	public class Person: BaseEntity
{ 
    public string Name { get; private set; }
	public string Family { get;private set; }
	public string? Email { get;private set; }
	public string? PhoneNumber { get; private set; }
	public bool Geger { get; private set; }
	public DateTime DateOfBirth { get; private set; }
    public Job Job { get; private set; }
    public int JobId { get; private set; }
    public List<EducationalRecord> EducationalRecords { get; private set; } = new List<EducationalRecord>();
    public List<PersonLanguages> PersonLanguages { get; private set; } = new List<PersonLanguages>();
    public List<WorkExperience> WorkExperiences { get; private set; } = new List<WorkExperience>();
    public City City { get; private set; }
    public int CityId { get; private set; }
    public List<PersonSkills> PersonSkills { get; private set; } = new List<PersonSkills>();
    //public Person(string name, string family, string? email, string? phoneNumber, bool geger, DateTime dateOfBirth, Job job, int jobId, List<EducationalRecord> educationalRecords, List<PersonLanguages> personLanguages, List<WorkExperience> workExperiences, City city, int cityId, List<PersonSkills> personSkills)
    //{
    //    Name = name;
    //    Family = family;
    //    Email = email;
    //    PhoneNumber = phoneNumber;
    //    Geger = geger;
    //    DateOfBirth = dateOfBirth;
    //    Job = job;
    //    JobId = jobId;
    //    EducationalRecords = educationalRecords;
    //    PersonLanguages = personLanguages;
    //    WorkExperiences = workExperiences;
    //    City = city;
    //    CityId = cityId;
    //    PersonSkills = personSkills;
    //}

   

    //public void Edit(string name, string family, string? email, string? phoneNumber, bool geger, DateTime dateOfBirth, Job job, int jobId, List<EducationalRecord> educationalRecords, List<PersonLanguages> personLanguages, List<WorkExperience> workExperiences, City city, int cityId, List<PersonSkills> personSkills)
    //{
    //    Name=name;
    //    Family=family;
    //    Email=email;
    //    PhoneNumber = phoneNumber;
    //    Geger = geger;
    //    DateOfBirth = dateOfBirth;
    //    Job = job;
    //    JobId = jobId;
    //    EducationalRecords = educationalRecords;
    //    PersonLanguages = personLanguages;
    //    WorkExperiences = workExperiences;
    //    City = city;
    //    CityId = cityId;
    //    PersonSkills = personSkills;
    //}
}

