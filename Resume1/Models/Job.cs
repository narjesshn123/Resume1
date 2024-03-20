namespace Resume1.Models;                   
	public class Job
	{
	public int Id { get; set; }
	public string Title { get; set; }
	public string EmploymentStatus { get; set; } 
	public List<Person> Person { get; set; }    
	}

