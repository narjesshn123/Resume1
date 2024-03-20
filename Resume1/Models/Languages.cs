namespace Resume1.Models; 
	public class Languages
	{
	public int Id { get; set; }
	public string Title { get; set; }
	public string Level { get; set; }//Enum
    public List<PersonLanguages>? PersonLanguages { get; set; }

}

