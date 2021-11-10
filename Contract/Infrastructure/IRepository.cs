using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EVA.Contract.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        Task<T> Get(long id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter = null
            , Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null
            , params Expression<Func<T, object>>[] includes
            );

        IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null
           , Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null
           );

        //Task<bool> SaveAll();
        void Update(T entity);
    }
}
