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
            User bea = new User { Name = "Beatrice", LoggedIn = false, UserId = 1, Avatar = "avatar1.jpg" };
            User tor = new User { Name = "Torbjörn", LoggedIn = false, UserId = 2, Avatar = "avatar5.jpg" };
            User bob = new User { Name = "Bob", LoggedIn = false, UserId = 3, Avatar = "avatar3.jpg" };
            User lisa = new User { Name = "Lisa", LoggedIn = false, UserId = 5, Avatar = "avatar2.jpg" };

            List<SubMessage> subMessages1 = new List<SubMessage>();
            SubMessage subMessage1 = new SubMessage { User = bea, MessageText = "Lugna ner dig Torbjörn-torrboll, jag tycker det fungerar bra!", MessageId = 3, Date = new DateTime(2020, 10, 17, 7, 10, 0), SubMessageId = 1 };
            SubMessage subMessage2 = new SubMessage { User = lisa, MessageText = "Torbjörn, jag ser att du åtminstone hittat knappen för att kunna markera viktiga inlägg, syftet är att lyfta fram VIKTIGA meddelanden. Missbruka inte den funktionen, jag avmarkerar nu ditt inlägg.", MessageId = 3, Date = new DateTime(2020, 10, 17, 7, 10, 0), SubMessageId = 2 };
            subMessages1.Add(subMessage1);
            subMessages1.Add(subMessage2);

            Messages.Add(new Message { User = lisa, MessageText = "Hej, vad kul!", MessageId = 1, Date = new DateTime(2020, 10, 15, 7, 10, 0), Pinned = false });
            Messages.Add(new Message { User = bea, MessageText = "Hej!!", MessageId = 2, Date = new DateTime(2020, 10, 16, 7, 10, 0), Pinned = false });
            Messages.Add(new Message { User = tor, MessageText = "Vad är det här för skitsida?!! Varför kör vi inte bara med Slack om vi prompt måste kommunicera med varandra? \"Vad har du på hjärtat?\" Jag kan inte ens göra en spy-emoji åt eländet...", MessageId = 3, Date = new DateTime(2020, 10, 22, 4, 35, 0), Pinned = false, SubMessages = subMessages1 });
            Messages.Add(new Message { User = lisa, MessageText = "På förekommen anledning: Använd bara pin-funktionen när det finns något viktigt och/eller brådskande att nå ut med.", MessageId = 4, Date = new DateTime(2020, 10, 23, 9, 15, 0), Pinned = true });
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
