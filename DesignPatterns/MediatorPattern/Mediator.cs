using DesignPatterns.MediatorPattern.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern
{
    internal delegate void MessageReceivedEventHandler(Message message, Person source);
    public class Mediator : IMediator
    {
        internal event MessageReceivedEventHandler MessageReceived;
        private Dictionary<string, Person> Participants = new Dictionary<string, Person>();
        
        public void RegisterParticipant(Person person)
        {
            Participants.Add(person.Name, person);
        }

        public void Shout(Message message, Person source)
        {
            // Extend separator beyond name and message length.
            var separatorLength = source.ToString().Length + message.Body.Length + 30;
            // Create separator with message and source
            Logging.LineSeparator($"'{message.Body}' from {source}", separatorLength, '=');
            // If handler isn't null, invoke MessageReceived event with message and source.
            MessageReceived?.Invoke(message, source);
        }
    }
}
