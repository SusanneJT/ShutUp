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
            Messages.Add(new Message { Name = "Urban", MessageText = "Hej!", MessageId = 1, Date = new DateTime(2020, 10, 15, 7, 0, 0) });
            Messages.Add(new Message { Name = "Ulla", MessageText = "Hoj!", MessageId = 2, Date = new DateTime(2020, 10, 15, 7, 10, 0) });

            return Messages;
        }

        public void NewMessage(Message message)
        {
            Messages.Add(message);
        }
    }
}
