using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace _0_Framework
{
    public class RepositoryBase<TKey, T> : IRepository<TKey, T> where T : class
    {
        private readonly DbContext _dbContext;

        public RepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(T entity)
        {
            _dbContext.Add<T>(entity);    
        }

        public bool Exists(Expression<Func<T, bool>>expersion)
        {
            return _dbContext.Set<T>().Any(expersion);   
        }  
        public T Get(TKey id)
        {
            return _dbContext.Find<T>(id); 
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();                        
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();     
        }
    }
}
