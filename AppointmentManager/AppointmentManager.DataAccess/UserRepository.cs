using System;
using System.Collections.Generic;
using AppointmentManager.DataAccess.Entities;

namespace AppointmentManager.DataAccess
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(IConnection connection)
            : base(connection)
        {
        }

        public override IEnumerable<User> Query(Func<User, bool> filter)
        {
            throw new NotImplementedException();
        }
    }
}
