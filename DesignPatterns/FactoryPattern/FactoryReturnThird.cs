using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class FactoryReturnThird : IFactoryReturn
    {
        public string GetValue()
        {
            return "This is the third object";
        }
    }
}
