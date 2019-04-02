using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class RemoveAllTheCs : IChain
    {
        private IChain _nextChain;

        public void Process(string input)
        {
            Debug.WriteLine("This would remove all the C's");
            if (_nextChain != null) _nextChain.Process("");
        }

        public void setNextChain(IChain nextInChain)
        {
            _nextChain = nextInChain;
        }
    }
}
