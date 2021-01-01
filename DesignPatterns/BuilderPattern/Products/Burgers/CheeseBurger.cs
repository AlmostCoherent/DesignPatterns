using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Products.Burgers
{
    public class CheeseBurger : Burger
    {
        public override string Name()
        {
            return "Cheese Burger";
        }

        public override float Price()
        {
            return 2.99F;
        }
    }
}
