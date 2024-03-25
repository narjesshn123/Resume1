using Resume.Core.Models;
using Resume1.AppContext;
using Resume1.Models;

namespace Resume.Repository.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ResumeContext _resumeContext;

        public PersonRepository(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }

        public void Create(Person person)
        {
            _resumeContext.Person.Add(person); 
        }

        public bool Exists(string Name)
        {
           return _resumeContext.Person.Any(x => x.Name == Name);   
        }

        public Person Get(int id)
        {
            return _resumeContext.Person.Find(id);
        }

        public List<Person> GetAll()
        {
            return _resumeContext.Person.ToList();  
        }

        public void SaveChanges()
        {
            _resumeContext.SaveChanges();  
        }
    }
}
