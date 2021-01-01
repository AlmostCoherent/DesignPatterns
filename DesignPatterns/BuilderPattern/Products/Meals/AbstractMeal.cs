using DesignPatterns.BuilderPattern.Products.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Products.Meals
{
    public abstract class AbstractMeal
    {
        internal Meal _meal;

        public AbstractMeal CreateMeal()
        {
            _meal = new Meal();
            return this;
        }

        public Meal GetMeal()
        {
            return _meal;
        }
        public AbstractMeal AddColdDrink(string drinkType)
        {
            ColdDrink coldDrink;
            switch(drinkType)
            {
                case "coke":
                    coldDrink = new Coke();
                    break;
                case "fanta":
                    coldDrink = new Fanta();
                    break;
                default:
                    coldDrink = null;
                    break;
            }
            _meal.SetColdDrink(coldDrink);
            return this;
        }

        public abstract AbstractMeal AddBurger();
    }
}
