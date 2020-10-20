using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShutUp.Shared;

namespace ShutUp.Client.Services.StateContainers
{
    public class MessageStateContainer
    {
        public List<Message> Messages { get; set; } = new List<Message>();

        public event Action OnChange;

        public void SetProperty(List<Message> _messages)
        {
            Messages = _messages;
            NotifyStateChanged();
        }

        public void ChangeProperty(Message message)
        {
            Messages.FirstOrDefault(x => message.MessageId == x.MessageId).Pinned = message.Pinned;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

