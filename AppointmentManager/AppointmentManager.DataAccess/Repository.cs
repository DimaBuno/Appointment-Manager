using System;
using System.Collections.Generic;
using System.Linq;

namespace AppointmentManager.DataAccess
{
    public abstract class Repository<T> : IRepository<T>
        where T : class, new()
    {
        private IConnection _connection;

        protected Repository(IConnection connection)
        {
            _connection = connection;
        }

        public abstract IEnumerable<T> Query(Func<T, bool> filter);

        protected IQueryable<T> Query()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void InsertRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
