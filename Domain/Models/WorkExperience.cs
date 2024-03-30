namespace Resume1.Models;                  
	public class WorkExperience
{
    //public WorkExperience(string title, string companyName, DateTime startDate, DateTime endDate, Person person, int personId)
    //{
    //    Title = title;
    //    CompanyName = companyName;
    //    StartDate = startDate;
    //    EndDate = endDate;
    //    Person = person;
    //    PersonId = personId;
    //}

    public int Id { get; set; }  
    public string Title { get; set; }
	public string CompanyName { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public Person Person { get; set; } 
	public int PersonId { get; set; }    
    public void Edit(string title, string companyName, DateTime startDate, DateTime endDate, Person person, int personId)
    {
        Title = title;
        CompanyName = companyName;
        StartDate = startDate;
        EndDate = endDate;
        Person = person;
        PersonId = personId;  
    }
}

