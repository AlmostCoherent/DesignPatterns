using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public abstract class ColdDrink : IItem
    {
        public abstract string Name();
        public abstract float Price();
        public IPacking Packing()
        {
            return new DrinkBottle();
        }
    }
}
