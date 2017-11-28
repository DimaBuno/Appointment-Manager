using System;
using System.Collections.Generic;

namespace AppointmentManager.DataAccess
{
    public interface IRepository<T> : IDisposable
    {
        IEnumerable<T> Query(Func<T, bool> filter);

        void Insert(T entity);

        void InsertRange(IEnumerable<T> entities);

        void Delete(T entity);

        void DeleteRange(IEnumerable<T> entities);

        void SaveChanges();
    }
}
