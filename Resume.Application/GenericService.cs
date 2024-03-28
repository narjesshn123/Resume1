using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Core.Models;

namespace Resume.Application
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public void Add(T entity)
        {
            _repository.Add(entity);    
        }

        public void Delete(int id)
        {
            _repository.Delete(id); 
        }

        public T GetById(int id)
        {
            return _repository.GetById(id); 
        }
        public List<T> GetAll()
        {
            return _repository.GetAll().ToList();     
        }
        public void Save()
        {
            _repository.SaveChanges();  
        }

        public void Update(T entity)
        {
            _repository.Update(entity); 
        }
    }
}
