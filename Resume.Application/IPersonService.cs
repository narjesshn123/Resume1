using Resume1.Models;

namespace Resume.Application
{
    public interface IPersonService 
    {
        Person GetPersonById(int id);
        void Create(Person entity);
        void UpdatePerson(Person person);
        void DeletePerson(Person person);
        void Save();
    }
}
