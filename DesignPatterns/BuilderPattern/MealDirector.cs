using DesignPatterns.BuilderPattern.Products.Meals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class MealDirector
    {
        public Meal GetMeal(AbstractMeal mealBuilder, string drinkType = null)
        {
            mealBuilder.CreateMeal()
                .AddBurger()
                .AddColdDrink(drinkType);
            return mealBuilder.GetMeal();
        }
    }
}
