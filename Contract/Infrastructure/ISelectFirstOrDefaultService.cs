using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EVA.Contract.Infrastructure
{
    public interface ISelectFirstOrDefaultService<TEntity> where TEntity : class
    {
        /// <summary>
        /// Get filterd data as per linq expression
        /// </summary>
        /// <param name="predicate">linq expression</param>
        /// <returns></returns>
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

    }
}
