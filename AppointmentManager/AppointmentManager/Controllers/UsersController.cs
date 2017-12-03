using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AppointmentManager.Service;
using AppointmentManager.Service.Models;

namespace AppointmentManager.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        // GET api/users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _service.Get();
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
