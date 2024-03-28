using Resume.Core.Models;
using Resume1.AppContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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
        public void Insert(T entity)
        {
            _dbset.Add(entity); 
        }

        public void Delete(T entity)
        {
            _resumeContext.Entry(entity).State = EntityState.Deleted;
        }

        public void Update(T entity)
        {
            _resumeContext.Entry(entity).State= EntityState.Modified;              
        }
        public void SaveChanges()
        {
            _resumeContext.SaveChanges();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> queryable = _dbset;
            if(filter != null)
            {
                queryable = queryable.Where(filter);    
            }
            return queryable;          
        }
    }


}
