namespace Resume1.Models; 
	public class Languages
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Name { get; set; }
    public string ?Level { get;  set; }//Enum
    public List<PersonLanguages>? PersonLanguages { get; private set; }
    //public Languages(string title, string level, List<PersonLanguages>? personLanguages)
    //{
    //    Title = title;
    //    Level = level;
    //    PersonLanguages = personLanguages;
    //}
    public void Edit(string title, string level, List<PersonLanguages>? personLanguages)
    {
        Title = title; Level = level; PersonLanguages = personLanguages;    
    }
}

