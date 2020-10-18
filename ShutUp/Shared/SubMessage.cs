using System;
using System.Collections.Generic;
using System.Text;

namespace ShutUp.Shared
{
    public class SubMessage
    {
        public User User { get; set; }
        public string MessageText { get; set; }
        public int MessageId { get; set; }
        public int SubMessageId { get; set; }
        public DateTime Date { get; set; }
    }
}
