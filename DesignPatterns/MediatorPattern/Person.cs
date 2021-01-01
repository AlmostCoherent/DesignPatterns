using DesignPatterns.MediatorPattern.Utility;

namespace DesignPatterns.MediatorPattern
{
    public class Person : IPerson
    {
        public string Name { get; }
        public Mediator Mediator { get; }

        public Person(string name, Mediator mediator)
        {
            Mediator = mediator;
            // Listen method subscribes to MessageReceived event handler.
            Mediator.MessageReceived += Listen;

            Name = name;

            mediator.RegisterParticipant(this);
        }

        /// <summary>
        /// Receives a message from source Person.
        /// </summary>
        /// <param name="message">Message received.</param>
        /// <param name="source">Person who sent the message.</param>
        public void Listen(Message message, Person source)
        {
            // If source is self, ignore.
            if (source == this) return;

            if(message.SentTo == null || this.Name == message.SentTo?.Name)
            {
                // Output received message.
                Logging.Log($"{source} to {this}: '{message.Body}'");

            };
        }

        /// <summary>
        /// Sends passed message to all subscribed Persons via Mediator.
        /// </summary>
        /// <param name="message">Message to be sent.</param>
        public void Say(Message message)
        {
            Mediator.Shout(message, this);
        }

        /// <summary>
        /// Overrides ToString() method.
        /// </summary>
        /// <returns>Name property value.</returns>
        public override string ToString() => Name;
    }
}