using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;        
using Resume1.Models;

namespace Resume.Core.Models
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter);  
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();



    }
}
