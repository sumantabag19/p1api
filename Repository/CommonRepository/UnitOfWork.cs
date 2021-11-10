using EVA.Contract;
using EVA.Contract.Infrastructure;

using EVA.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace JCI.JEM.Entity.Repository
{
    /// <summary>
    /// UnitOfWork class take cares of context and database changes
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        #region Private Variables
        private readonly DbContext _context;
        private bool _disposed;

        //private IRepository<Activity> _activityRepository;
        //private IRepository<label_header> _lableHeaderRepository;
        //private IRepository<label_display> _lableDisplayRepository;




        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to initialize DBContext.
        /// </summary>
        /// <param name="DbContext"></param>
        public UnitOfWork(DbContext context)
        {
            _context = context;
            _disposed = false;
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Get the DBContext. 
        /// </summary>
        public DbContext DataContext
        {
            get { return _context; }
        }

      




        //public IRepository<label_header> LableHeaderRepository
        //{
        //    get { return _lableHeaderRepository = _lableHeaderRepository ?? new GenericRepository<label_header>(_context); }
        //}


        //public IRepository<label_display> LableDisplayRepository
        //{
        //    get { return _lableDisplayRepository = _lableDisplayRepository ?? new GenericRepository<label_display>(_context); }
        //}



        #endregion

        #region Dispose
        /// <summary>
        /// Method to dispose by parameter.
        /// </summary>
        /// <param name="disposing"></param>
        /// 
        protected void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                if (_context != null)
                    _context.Dispose();
            }

            _disposed = true;
        }

        /// <summary>
        /// Method to dispose.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<bool> Commit()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Rollback()
        {
            _context.Dispose();
        }

        #endregion
    }
}
