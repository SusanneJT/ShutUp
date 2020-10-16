using ShutUp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShutUp.Server.Models
{
    public class UserRepository : IUserRepository
    {
        public List<User> RegisteredUsers { get; set; } = new List<User>();
        public IEnumerable<User> GetUsers()
        {
            RegisteredUsers.Add(new User { Name = "Uno", LoggedIn = false, UserId = 1});
            RegisteredUsers.Add(new User { Name = "Vera", LoggedIn = false, UserId = 2 });
            RegisteredUsers.Add(new User { Name = "Torbjörn", LoggedIn = false, UserId = 3 });
            RegisteredUsers.Add(new User { Name = "Gäst", LoggedIn = false, UserId = 4 });

            return RegisteredUsers;
        }
    }
}
