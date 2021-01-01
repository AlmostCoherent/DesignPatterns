using DesignPatterns.CompositePattern;
using DesignPatterns.MediatorPattern;
using System;
using Xunit;

namespace DesignPatterns.Tests
{
	public class MediatorPatternTests
	{
		[Fact]
		public void TestMediator()
		{
            var crier = new Mediator();

            // Create some people and assign the crier.
            var arya = new Person("Arya Stark", crier);
            var cersei = new Person("Cersei Lannister", crier);
            var daenerys = new Person("Daenerys Targaryen", crier);
            // Without a tongue it's difficult to speak, so Ilyn remains silent and listens.
            var ilyn = new Person("Ilyn Payne", crier);
            var tyrion = new Person("Tyrion Lannister", crier);

            // Send messages from respective characters.
            arya.Say(new Message("Valar morghulis.", cersei));
            tyrion.Say(new Message("Never forget what you are, for surely the world will not."));
            daenerys.Say(new Message("Men are mad and gods are madder."));
            cersei.Say(new Message("When you play the game of thrones, you win or you die. There is no middle ground."));
        }
	}
}
