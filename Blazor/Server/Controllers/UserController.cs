using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Server.Data;

using Blazor.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Server.Controllers
{
    public class UserController : Controller
        {

        private readonly UserRepository userRepository;
        public UserController()
        {
            this.userRepository = new UserRepository();
        }
        // FilmDataAccessLayer userRepository = new FilmDataAccessLayer();
        [HttpGet]
        [Route("api/User/Index")]
        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetAllU();
        }
       
        [HttpPost]
        [Route("api/User/Create")]
        public void Create([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                userRepository.AddUser(user);
            }
        }
        [HttpGet]
        [Route("api/User/Details/{id}")]
        public User Details(int id)
        {
            return userRepository.GetUser(id);
        }
        [HttpGet]
        [Route("api/User/DetailsByEmail/{email}")]
        public User DetailsByEmail(string email)
        {
            return userRepository.GetUser(email);
        }
        [HttpPut]
        [Route("api/User/Edit")]
        public void Edit([FromBody] User user)
        {
            userRepository.UpdateUser(user);
        }
        [HttpDelete]
        [Route("api/User/Delete/{id}")]
        public void Delete(int id)
        {
            userRepository.DeleteUser(id);
        }


    }
}


