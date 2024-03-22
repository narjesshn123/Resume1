namespace Resume1.Models;                  
	public class WorkExperience
	{
	public int Id { get; set; }
	public string Title { get; set; }
	public string CompanyName { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public Person Person { get; set; } 
	public int PersonId { get; set; }                    
}

