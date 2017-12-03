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
            //TODO: Replace with real database.
            return new List<User> {
                new User { FirstName = "User", LastName = "1" },
                new User { FirstName = "User", LastName = "2" }
            };
        }
    }
}
