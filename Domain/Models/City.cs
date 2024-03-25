namespace Resume1.Models; 
	public class City: BaseEntity
    {
    //public int Id { get; set; }
    public string Name { get; set; }
	public List<Person> persons { get; set; } = new List<Person>();
    public City(string name, List<Person> persons)
    {
        Name = name;
        this.persons = persons;
    }
    public void Edit(string name, List<Person> persons)
    {
        Name = name; 
        this.persons = persons;
    }
}

