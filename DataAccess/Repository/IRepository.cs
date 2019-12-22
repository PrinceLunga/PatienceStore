using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatienceShoppingPlatform.DataAccess.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Find(Func<T, bool> predicate);
    }
}
