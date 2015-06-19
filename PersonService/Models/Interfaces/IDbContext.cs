using System;
using System.Data.Entity;

namespace PersonService.Models.Contracts
{
    public interface IDbContext : IDisposable
    {
        IDbSet<T> CreateDbSet<T>() where T : class;
        void SaveChanges();
    }
}