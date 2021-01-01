using DesignPatterns.BuilderPattern.Products.Burgers;
using DesignPatterns.BuilderPattern.Products.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Products.Meals
{
    public class Meal
    {
        private Burger Burger { get; set; }
        public void SetBurger(Burger burger)
        {
            Burger = burger;
            TotalValue += burger.Price();
        }
        public Burger GetBurger()
        {
            return Burger;
        }

        private ColdDrink ColdDrink { get; set; }
        public void SetColdDrink(ColdDrink coldDrink)
        {
            if(coldDrink != null)
            {
                ColdDrink = coldDrink;
                TotalValue += coldDrink.Price();
            }
        }
        public ColdDrink GetColdDrink()
        {
            return ColdDrink;
        }
        public float TotalValue { get; set; }

    }
}
