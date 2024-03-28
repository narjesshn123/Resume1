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
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void SaveChanges();

        //void Create(Person person);
        //Person Get(int id);
        //List<Person> GetAll();
        //bool Exists(string Name);
        //void SaveChanges();

        //        {
        //    T Get(TKey id);
        //    List<T> GetAll();
        //    void Create(T entity);
        //    bool Exists(Expression<Func<T, bool>> expersion);
        //    void SaveChanges();

        //}
    }
}
