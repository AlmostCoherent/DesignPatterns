using DesignPatterns.ChainOfResponsibility;
using Xunit;

namespace DesignPatterns.Tests
{

    public class ChainOfCommandTests
    {
        [Fact]
        public void ShouldRemoveTags()
        {
            IChain chainBs = new RemoveAllTheBs();
            IChain chainCs = new RemoveAllTheCs();
            chainBs.setNextChain(chainCs);
            chainBs.Process("");
        }
    }
}
