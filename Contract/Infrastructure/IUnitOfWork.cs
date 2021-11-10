using System;
using System.Threading.Tasks;
using EVA.Contract.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace EVA.Contract
{
    // <summary>
    /// Interface for the UnitOfWork class.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        DbContext DataContext { get; }
        Task<bool> Commit();
        void Rollback();
        //  IRepository<Activity> ActivityRepository { get; }
        // IRepository<Contact> ContactRepository { get; }
        // IRepository<label_header> LableHeaderRepository { get; }
        // IRepository<label_display> LableDisplayRepository { get; }

    }
}
