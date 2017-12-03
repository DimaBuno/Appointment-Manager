using AppointmentManager.Service.Models;
using System.Collections.Generic;

namespace AppointmentManager.Service
{
    public interface IUserService
    {
        IEnumerable<User> Get();
    }
}
