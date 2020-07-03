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
           
        FilmDataAccessLayer objkor = new FilmDataAccessLayer();
        [HttpGet]
        [Route("api/User/Index")]
        public IEnumerable<User> GetUsers()
        {
            return objkor.GetAll();
        }
       
        [HttpPost]
        [Route("api/User/Create")]
        public void Create([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                objkor.AddUser(user);
            }
        }
        [HttpGet]
        [Route("api/User/Details/{id}")]
        public User Details(int id)
        {
            return objkor.GetUser(id);
        }
        [HttpGet]
        [Route("api/User/DetailsByEmail/{email}")]
        public User DetailsByEmail(string email)
        {
            return objkor.GetUser(email);
        }
        [HttpPut]
        [Route("api/User/Edit")]
        public void Edit([FromBody] User user)
        {
            objkor.UpdateUser(user);
        }
        [HttpDelete]
        [Route("api/User/Delete/{id}")]
        public void Delete(int id)
        {
            objkor.DeleteUser(id);
        }


    }
}


