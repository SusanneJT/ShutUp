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
            User Torbjorn = new User { Name = "Torbjörn", LoggedIn = false, UserId = 2 };
            //User Gast = new User { Name = "Gäst", LoggedIn = false, UserId = 2 };

            //Message subMessage = new Message { User = Vera, MessageText = "Hoppla!", MessageId = 2, Date = new DateTime(2020, 10, 16, 7, 10, 0) };
            List<SubMessage> subMessages1 = new List<SubMessage>();
            SubMessage subMessage1 = new SubMessage { User = Torbjorn, MessageText = "Hej Uno!!", MessageId = 1, Date = new DateTime(2020, 10, 17, 7, 10, 0), SubMessageId = 1 };
            subMessages1.Add(subMessage1);

            Messages.Add(new Message { User = Uno, MessageText = "Hoj!", MessageId = 1, Date = new DateTime(2020, 10, 15, 7, 10, 0), SubMessages = subMessages1, Pinned = false });
            Messages.Add(new Message { User = Vera, MessageText = "Hoppla!", MessageId = 2, Date = new DateTime(2020, 10, 16, 7, 10, 0), Pinned = false });
            Messages.Add(new Message { User = Torbjorn, MessageText = "Holl koll på larmen!", MessageId = 3, Date = new DateTime(2020, 10, 18, 7, 10, 0), Pinned = true });
            return Messages;
        }

        public void NewMessage(Message message)
        {
            Messages.Add(message);
        }
        public void NewMessage(SubMessage subMessage)
        {
            //Messages.Add(message);
        }

        public void ChangeMessage(Message message)
        {
            //Change message where id = message.id
        }
    }
}
