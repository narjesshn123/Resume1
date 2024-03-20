namespace Resume1.Models; 
	public class Person
	{
	public int Id { get; set; } 
	public string Name { get; set; }
	public string Family { get; set; }
	public string? Email { get; set; }
	public string? PhoneNumber { get; set; }
	public bool Geger { get; set; }
	public DateTime DateOfBirth { get; set; }
	public Job Job { get; set; }                
	public int JobId { get; set; }   
	public List<EducationalRecord> EducationalRecords { get; set; } = new List<EducationalRecord>(); 
	public List<PersonLanguages> PersonLanguages { get; set; } = new List<PersonLanguages>();					
	public List<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
	public City City { get; set; }
	public int CityId { get; set; }
    public List<PersonSkills> PersonSkills { get; set; } = new List<PersonSkills>();																
	  
}

