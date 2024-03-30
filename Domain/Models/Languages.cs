namespace Resume1.Models; 
	public class Languages
{
    public int Id { get; set; }
    public string Title { get; private set; }
	public string Level { get; private set; }//Enum
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

