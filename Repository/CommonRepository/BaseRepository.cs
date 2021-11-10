using EVA.Contract;
using EVA.Contract.Operations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EVA.Repositories
{
    /// <summary>
    /// Base Repository class is a base class which provides basic Add, Update, Delete functionality to other repositories 
    /// Each CRUD operation should to maintain traice audit and for that User name details are important
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        #region Private Variable


        #endregion

        #region Constructor
        public BaseRepository()
        {
        }
        #endregion


        public IUnitOfWork _unitOfWork { get; set; }

        #region public Methods
        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate != null)
                return await _unitOfWork.DataContext.Set<TEntity>().Where(predicate).CountAsync();
            else
                return await _unitOfWork.DataContext.Set<TEntity>().CountAsync();
        }
        /// <summary>
        /// Add new record in entity provided by repository
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task AddAsync(TEntity entity)
        {
            await _unitOfWork.DataContext.Set<TEntity>().AddAsync(entity);
        }
        /// <summary>
        /// Modify single record from entity provided by repository
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => _unitOfWork.DataContext.Set<TEntity>().Update(entity));
        }

        /// <summary>
        /// Delete single record from entity provided by repository
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => _unitOfWork.DataContext.Set<TEntity>().Remove(entity));
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _unitOfWork.DataContext.Set<TEntity>().AddRangeAsync(entities);
        }

        public virtual async Task UpdateRange(IEnumerable<TEntity> entities)
        {
            await Task.Run(() => _unitOfWork.DataContext.Set<TEntity>().UpdateRange(entities));
        }

        public async Task<IList<TResult>> SelectAsyncList<TResult>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TResult>> selectPredicate)
        {
            return await _unitOfWork.DataContext.Set<TEntity>().Where(predicate).Select(selectPredicate).ToListAsync();
        }
        /// <summary>
        /// Delete single record from entity provided by repository
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task DeleteRangeAsync(IEnumerable<TEntity> entities)
        {
            await Task.Run(() => _unitOfWork.DataContext.Set<TEntity>().RemoveRange(entities));
        }

        public async Task<IList<TEntity>> SelectAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate != null)
                return await _unitOfWork.DataContext.Set<TEntity>().Where(predicate).ToListAsync();
            else
                return await _unitOfWork .DataContext.Set<TEntity>().ToListAsync();
        }



        #endregion
    }
}
