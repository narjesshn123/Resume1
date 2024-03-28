using Resume.Core.Models;
using Resume1.AppContext;
using Resume1.Models;
using Resume.Core;
using Microsoft.EntityFrameworkCore;

namespace Resume.Repository.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ResumeContext _resumeContext;
        private readonly DbSet<T> _dbset; 
       

        public GenericRepository(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
            _dbset = _resumeContext.Set<T>();                  
        }
        public void Add(T entity)
        {
            _dbset.Add(entity);    
        }

        public void Delete(int id)
        {
            var entity = _dbset.Find(id);    
            if (entity != null)
            {
                _dbset.Remove(entity);
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _dbset.ToList();      
        }

        public T GetById(int id)
        {
            return _dbset.Find(id);   
        }

        public void Update(T entity)
        {
            _dbset.Update(entity);
        }
        public void SaveChanges()
        {
            _resumeContext.SaveChanges();
        }
    }


}
