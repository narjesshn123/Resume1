

using Microsoft.EntityFrameworkCore;

namespace Resume1.AppContext
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {      
        ResumeContext db;
        private DbSet<TEntity> _dbset;
        public GenericRepository(ResumeContext context)
        {
            _dbset = context.Set<TEntity>();

            db = context;
        }
        public bool Delete(TEntity entity)
        {
            try
            {
                _dbset.Entry(entity).State = EntityState.Deleted;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = GetbyId(id);   
                _dbset.Entry(entity).State = EntityState.Deleted;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbset.ToList();      

        }

        public TEntity GetbyId(int id)
        {
            return _dbset.Find(id); 
        }

        public bool Insert(TEntity entity)
        {
            try {
                _dbset.Add(entity);
                return true;         
            }
            catch(Exception ex) {
                return false;                               
            }  
        }

    
        public bool Update(TEntity entity)
        {
            try
            {
                _dbset.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception ex)
            {
                return false; 
            }
               
        }
        public void Save()
        {
            db.SaveChanges();
        }

    }
}
