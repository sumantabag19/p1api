
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EVA.Contract.Operations
{
    /// <summary>
    /// This interface provide collection of all base operation interfaces
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseRepository<TEntity> : IAddService<TEntity>, IUpdateService<TEntity>, IDeleteService<TEntity>, ISelectService<TEntity> where TEntity : class
    {
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null);
    }
}
