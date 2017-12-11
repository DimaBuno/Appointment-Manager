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
                new User { UserId= "1", DateBday ="01.01.2000", Email="123@gmail.com", GenderId = "1", Login ="User1", Password="123456", Role="Admin",  FirstName = "John", LastName = "1" },
                new User { UserId= "2", DateBday ="02.02.2001", Email="abc@gmail.com", GenderId = "2", Login ="User2", Password="123456", Role="Employee",  FirstName = "Ann", LastName = "1" }
            };
        }
    }
}
