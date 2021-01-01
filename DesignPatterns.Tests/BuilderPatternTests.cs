using DesignPatterns.BuilderPattern;
using DesignPatterns.BuilderPattern.Products.Meals;
using Xunit;

namespace DesignPatterns.Tests
{
	public class BuilderPatternTests
	{
		[Fact]
		public void CheckBuilder()
		{
			MealDirector mealDirector = new MealDirector();

			AbstractMeal abstractMeal = new CheeseBurgerMeal();
			Meal meal = mealDirector.GetMeal(abstractMeal, "fanta");

			Assert.NotNull(meal);
			Assert.Equal("4.98", meal.TotalValue.ToString());
			Assert.Equal("Cheese Burger", meal.GetBurger().Name());
			Assert.Equal("Fanta", meal.GetColdDrink().Name());

			meal = mealDirector.GetMeal(abstractMeal, "coke");

			Assert.NotNull(meal);
			Assert.Equal("4.98", meal.TotalValue.ToString());
			Assert.Equal("Cheese Burger", meal.GetBurger().Name());
			Assert.Equal("Coke", meal.GetColdDrink().Name());

		}
	}
}
