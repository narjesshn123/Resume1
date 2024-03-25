using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework
{
    public class RepositoryBase<TKey, T> : IRepository<TKey, T> where T : class
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string Name)
        {
            throw new NotImplementedException();
        }

        public T Get(TKey id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
