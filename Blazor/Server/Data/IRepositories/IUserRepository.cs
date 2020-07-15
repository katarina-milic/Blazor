using Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Data
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAllU();
        User GetUser(int id);
        User GetUser(string email);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}

