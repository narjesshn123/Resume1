namespace Resume1.Models; 
	public class City
	{
	public int Id { get; set; }
	public string Name { get; set; }
	public List<Person> persons { get; set; } = new List<Person>();                    
}

