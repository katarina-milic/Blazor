using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Server.Data;
using Blazor.Server.Helpers;
using Blazor.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Server.Controllers
{
    public class UserController : Controller
        {
            //private readonly FilmContext context;
            FilmDataAccessLayer objkor = new FilmDataAccessLayer();

     /*   public UserController(FilmContext context)
            {
                this.context = context;
            }*/

            [HttpGet]
            [Route("api/User/Index")]
        public IEnumerable<User> GetUsers()
        {
            return objkor.GetAll();
        }
       /* public async Task<ActionResult<List<User>>> GetAllUsers([FromQuery] PaginationDTO pagination,
                [FromQuery] string name)
            {
                var queryable = context.Korisnici.AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                    queryable = queryable.Where(x => x.FirstName.Contains(name));
                }
                await HttpContext.InsertPaginationParameterInResponse(queryable, pagination.QuantityPerPage);
                return await queryable.Paginate(pagination).ToListAsync();

             }*/
       


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


