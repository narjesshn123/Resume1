using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Core.Models;
using Resume1.Models;

namespace Resume.Application
{
    public class PersonService : IPersonService
    {
        private readonly IGenericRepository<Person> _genericRepository;

        public PersonService(IGenericRepository<Person> repository)
        {
            _genericRepository = repository;
        }

        public void Create(Person entity)
        {
            _genericRepository.Insert(entity);   
        }

        public void DeletePerson(Person person)
        {
            _genericRepository.Delete(person); 
        }

        public Person GetPersonById(int id)
        {
            return _genericRepository.GetAll(p => p.Id == id).SingleOrDefault();
        }
   
        public void Save()
        {
            _genericRepository.SaveChanges();  
        }

        public void UpdatePerson(Person entity)
        {
            _genericRepository.Update(entity); 
        }
    }

  
}
