using ShutUp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShutUp.Server.Models
{
    public interface IMessageRepository
    {
        IEnumerable<Message> GetMessages();
        void NewMessage(Message message);
    }
}
