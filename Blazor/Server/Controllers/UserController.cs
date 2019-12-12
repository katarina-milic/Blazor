using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public IEnumerable<User> GetUsers()
        {
            var output = new List<User>
            {
                new User
                {   Username = "AP",
                    FirstName = "Aleksa",
                    LastName = "Pavlovic",
                    Password = "Aleksa123."

                },
                new User
                {   Username = "KM",
                    FirstName = "Katarina",
                    LastName = "Milic",
                    Password = "Katarina123."

                },
                new User
                {   Username = "VM",
                    FirstName = "Vidan",
                    LastName = "Milojevic",
                    Password = "Vidan123."

                },
                new User
                {
                    Username = "LM",
                    FirstName = "Lazar",
                    LastName = "Miric",
                    Password = "Lazar123."

                }
            };
            return output;
        }
        [HttpPost]
        public void Post (User user)
        {
                
        }

    }
}