using System;
using System.Diagnostics;

namespace DesignPatterns.ChainOfResponsibility
{
    public class RemoveAllTheBs : IChain
    {
        private IChain _nextChain;
        public void Process(string input)
        {
            Debug.WriteLine("This would remove all the B's");
            if (_nextChain != null) _nextChain.Process("");
        }

        public void setNextChain(IChain nextInChain)
        {
            _nextChain = nextInChain;
        }
    }
}
