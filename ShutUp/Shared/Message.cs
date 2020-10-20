using System;
using System.Collections.Generic;
using System.Text;

namespace ShutUp.Shared
{
    public class Message
    {
        public User User { get; set; }
        public string MessageText { get; set; }
        public int MessageId { get; set; }
        public List<SubMessage> SubMessages { get; set; }
        public bool Pinned { get; set; }
        public DateTime Date { get; set; }

    }
}
