using ShutUp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShutUp.Server.Models
{

    public class MessageRepository : IMessageRepository
    {
        public List<Message> Messages { get; set; } = new List<Message>();
        public IEnumerable<Message> GetMessages()
        {
            User Uno = new User { Name = "Uno", LoggedIn = false, UserId = 1 };
            User Vera = new User { Name = "Vera", LoggedIn = false, UserId = 2 };
            //User Torbjorn = new User { Name = "Torbjörn", LoggedIn = false, UserId = 2 };
            //User Gast = new User { Name = "Gäst", LoggedIn = false, UserId = 2 };

            Messages.Add(new Message { User = Uno, MessageText = "Hoj!", MessageId = 1, Date = new DateTime(2020, 10, 15, 7, 10, 0) });
            Messages.Add(new Message { User = Vera, MessageText = "Hoppla!", MessageId = 2, Date = new DateTime(2020, 10, 16, 7, 10, 0) });
            return Messages;
        }

        public void NewMessage(Message message)
        {
            Messages.Add(message);
        }
    }
}
