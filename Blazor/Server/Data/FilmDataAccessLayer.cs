using Blazor.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Server.Helpers;

namespace Blazor.Server.Data
{
    public class FilmDataAccessLayer
    {
        FilmContext db = new FilmContext();
        public IEnumerable<Film> GetAllFilms()
        {
            return db.Filmovi.ToList();

        }
        public Film GetFilm (int id)
        {
            var film = db.Filmovi.Find(id);
            return film;
        }
        public void AddFilm (Film film)
        {
            db.Filmovi.Add(film);
            db.SaveChanges();
        }
        public void UpdateFilm (Film film)
        {
            db.Entry(film).State = EntityState.Modified;
            db.SaveChanges();

        }
        public void DeleteFilm (int id)
        {
            var film = db.Filmovi.Find(id);
            db.Filmovi.Remove(film);
            db.SaveChanges();
        }

      /*  public async Task<ActionResult<List<User>>> GetAll([FromQuery] PaginationDTO pagination,
                [FromQuery] string name)
        {
            var queryable = db.Korisnici.AsQueryable();
            if (!string.IsNullOrEmpty(name))
            {
                queryable = queryable.Where(x => x.FirstName.Contains(name));
            }
            await HttpContext.InsertPaginationParameterInResponse(queryable, pagination.QuantityPerPage);
            return await queryable.Paginate(pagination).ToListAsync();

        }*/
       public IEnumerable<User> GetAll()
        {
            return db.Korisnici.ToList();

        } 
        public User GetUser(int id)
        {
            var user = db.Korisnici.Find(id);
            return user;
        }
        public void AddUser(User user)
        {
            db.Korisnici.Add(user);
            db.SaveChanges();
        }
        public void UpdateUser(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();

        }
        public void DeleteUser(int id)
        {
            var user = db.Korisnici.Find(id);
            db.Korisnici.Remove(user);
            db.SaveChanges();
        }
    }
}
