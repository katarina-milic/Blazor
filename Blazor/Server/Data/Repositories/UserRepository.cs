using Blazor.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Data
{
    public class UserRepository : Repository<User>, IUserRepository

    {
        private readonly FilmContext userContext;

        public UserRepository(FilmContext userContext) : base(userContext)
        {
           // this.userContext = userContext;

        }


        public IEnumerable<User> GetAllU()
        {
            return userContext.Korisnici.ToList();

        }
        public User GetUser(int id)
        {
            var user = userContext.Korisnici.Find(id);
            return user;
        }
        public User GetUser(string email)
        {
            var user = userContext.Korisnici.Where(item => item.Email == email).ToList().FirstOrDefault();
            return user;
        }
       
        public void AddUser(User user)
        {
            userContext.Korisnici.Add(user);
            userContext.SaveChanges();
        }
        public void UpdateUser(User user)
        {
            userContext.Entry(user).State = EntityState.Modified;
            userContext.SaveChanges();

        }
        public void DeleteUser(int id)
        {
            var user = userContext.Korisnici.Find(id);
            userContext.Korisnici.Remove(user);
            userContext.SaveChanges();
        }
        public FilmContext FilmContext
        {
            get { return Context as FilmContext; }
        }
    }
}
