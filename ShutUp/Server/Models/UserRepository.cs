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
            RegisteredUsers.Add(new User { Name = "Beatrice", LoggedIn = false, UserId = 1, Avatar = "avatar1.jpg"});
            RegisteredUsers.Add(new User { Name = "Torbjorn", LoggedIn = false, UserId = 2, Avatar = "avatar5.jpg" });
            RegisteredUsers.Add(new User { Name = "Bob", LoggedIn = false, UserId = 3, Avatar = "avatar3.jpg" });
            RegisteredUsers.Add(new User { Name = "Uno", LoggedIn = false, UserId = 4, Avatar = "avatar6.jpg" });
            RegisteredUsers.Add(new User { Name = "Lisa", LoggedIn = false, UserId = 5, Avatar = "avatar2.jpg" });
            RegisteredUsers.Add(new User { Name = "Gäst", LoggedIn = false, UserId = 6, Avatar = "avatar8.jpg" });

            return RegisteredUsers;
        }
    }
}
