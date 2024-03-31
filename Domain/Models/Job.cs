namespace Resume1.Models;                   
	public class Job
{
    //public Job(string title, string employmentStatus, List<Person> person)
    //{
    //    Title = title;
    //    EmploymentStatus = employmentStatus;
    //    Person = person;
    //}
    public void Edit(string title, string employmentStatus, List<Person> person)
    {
        Title = title;
        EmploymentStatus = employmentStatus;
        Person = person;        
    }
    public int Id { get; set; }
    public string? Title { get; set; }
	public string ?EmploymentStatus { get; set; } 
	public List<Person> Person { get; set; }    
	}

