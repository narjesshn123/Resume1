namespace Resume1.Models; 
	public class Person
{ 
    public int Id { get; set; } 
    public string? Name { get; set; }
	public string? Family { get; set; }
	public string? Email { get; set; }
	public string? PhoneNumber { get;  set; }
	public bool Geger { get; set; }
	public DateTime DateOfBirth { get;  set; }
    public Job? Job { get;  set; }
    public int? JobId { get;  set; }
    public List<EducationalRecord>? EducationalRecords { get; set; } = new List<EducationalRecord>();
    public List<PersonLanguages>? PersonLanguages { get;  set; } = new List<PersonLanguages>();
    public List<WorkExperience>? WorkExperiences { get; set; } = new List<WorkExperience>();

    public List<PersonSkills> ?PersonSkills { get; set; } = new List<PersonSkills>();
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

