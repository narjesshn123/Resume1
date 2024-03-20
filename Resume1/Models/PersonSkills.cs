namespace Resume1.Models;
public class PersonSkills
{
    public int PersonId { get; set; }
    public Person Person { get; set; }                  
    public int SkillId { get; set; } 
    public Skills Skills { get; set; }

}
