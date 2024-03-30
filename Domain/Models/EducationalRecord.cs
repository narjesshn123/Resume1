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
    //public EducationalRecord(string feildOfStudy, string universityName, string grade, DateTime startDate, DateTime endDate, Person person, int personId)
    //{
    //    FeildOfStudy = feildOfStudy;
    //    UniversityName = universityName;
    //    Grade = grade;
    //    this.startDate = startDate;
    //    EndDate = endDate;
    //    Person = person;
    //    PersonId = personId;
    //}
    public void Edit(string feildOfStudy, string universityName, string grade, DateTime startDate, DateTime endDate, Person person, int personId)
    {
        FeildOfStudy = feildOfStudy;
        UniversityName= universityName;
        Grade = grade;
        this.startDate = startDate;
        EndDate = endDate;
        Person = person;
        PersonId = personId;        
    }
}

