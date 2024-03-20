namespace Resume1.Models;              
	public class Skills
	{
	public int Id { get; set; } 
	public string Title { get; set; }
	public string Proficiency { get; set; } 
	public List<PersonSkills> PersonSkills { get; set; }	 

	}

