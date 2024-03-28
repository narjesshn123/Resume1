namespace Resume1.Models;              
	public class Skills: BaseEntity
    {
    //public int Id { get; set; }  
    public string Title { get; set; } 
	public string Proficiency { get; set; } 
	public List<PersonSkills> PersonSkills { get; set; }
    //public Skills(string title, string proficiency, List<PersonSkills> personSkills)
    //{
    //    Title = title;
    //    Proficiency = proficiency;
    //    PersonSkills = personSkills;
    //}
    public void Edit(string title, string proficiency, List<PersonSkills> personSkills)
    {
        Title = title;
        Proficiency = proficiency;
        PersonSkills = personSkills;
    }
}

