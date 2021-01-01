using DesignPatterns.CompositePattern;
using System;
using Xunit;

namespace DesignPatterns.Tests
{
	public class CompositePatternTests
	{
		[Fact]
		public void TestCompositeObject()
		{
            Client client = new Client();

            // This way the client code can support the simple leaf
            // components...
            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);

            // ...as well as the complex composites.
            Composite tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            var resutl = client.ClientCode2(tree, leaf);
            Assert.NotNull(resutl);
            Assert.Equal(resutl, "Branch(Branch(Leaf+Leaf)+Branch(Leaf)+Leaf)");
        }
	}
}
