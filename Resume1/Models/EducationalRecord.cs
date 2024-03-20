namespace Resume1.Models;  
	public class EducationalRecord
	{
	public int Id { get; set; } 
	public string FeildOfStudy { get; set; }
	public string UniversityName { get; set; }
	public string Grade { get; set; } //enum 
	public DateTime startDate { get; set; } 
	public DateTime EndDate { get; set; } 
	public Person Person { get; set; } 
	public int PersonId { get; set; }

}

