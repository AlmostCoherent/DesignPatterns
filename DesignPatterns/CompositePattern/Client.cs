using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositePattern
{
    public class Client
    {
        public void ClientCode(AbstractComponent leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation()}\n");
        }
        public string ClientCode2(AbstractComponent abstractComponent1, AbstractComponent abstractComponent2)
        {
            if (abstractComponent1.IsComposite())
            {
                abstractComponent1.Add(abstractComponent2);
            }
            Console.WriteLine($"RESULT: {abstractComponent1.Operation()}");
            return abstractComponent1.Operation();
        }
    }
}
