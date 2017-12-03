using System.Collections.Generic;
using AppointmentManager.DataAccess;
using System.Linq;

namespace AppointmentManager.Service
{
    public class UserService : IUserService
    {
        private IRepository<DataAccess.Entities.User> _repository;

        public UserService(IRepository<DataAccess.Entities.User> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Models.User> Get()
        {
            var users = _repository.Query(u => u != null);
            return users.Select(u => new Models.User { FirstName = u.FirstName, LastName = u.LastName });
        }
    }
}
