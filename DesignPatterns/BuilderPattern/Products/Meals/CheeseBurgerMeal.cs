using DesignPatterns.BuilderPattern.Products.Burgers;
using DesignPatterns.BuilderPattern.Products.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Products.Meals
{
    public class CheeseBurgerMeal : AbstractMeal
    {
        public override AbstractMeal AddBurger()
        {
            _meal.SetBurger(new CheeseBurger());
            return this;
        }
    }
}
