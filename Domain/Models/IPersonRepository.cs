using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume1.Models;

namespace Resume.Core.Models
{
    public interface IPersonRepository
    {
        void Create(Person person);
        Person Get(int id); 
        List<Person> GetAll();
        bool Exists(string Name);
        void SaveChanges(); 
    }
}
