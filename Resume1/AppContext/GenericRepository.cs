using Microsoft.EntityFrameworkCore;

namespace Resume1.AppContext
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _dbset;
       
        private ResumeContext _context; 
        public GenericRepository(ResumeContext resumeContext)
        {
            _dbset = resumeContext.Set<TEntity>(); 
           
            _context = resumeContext; 
        }

        public void Delete(TEntity entity)
        {
           if(_context.Entry(entity).State == EntityState.Detached)
            {
                _dbset.Attach(entity);  
            }
           _dbset.Remove(entity);         
        }

        public List<TEntity> GetAll()
        {
           return _dbset.ToList(); 
        }

        public TEntity GetbyId(int id)
        {
            return _dbset.Find(id); 
        }

        public void Insert(TEntity entity)
        {
            _dbset.Add(entity);    
        }

        public void Save()
        {
            _context.SaveChanges();  
        }

        public void Update(TEntity entity)
        {
            _dbset.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified; 
        }
    }
}
