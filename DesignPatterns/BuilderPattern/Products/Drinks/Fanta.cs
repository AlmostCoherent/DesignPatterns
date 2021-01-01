using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Products.Drinks
{
    public class Fanta : ColdDrink
    {
        public override string Name()
        {
            return "Fanta";
        }

        public override float Price()
        {
            return 1.99F;
        }
    }
}
