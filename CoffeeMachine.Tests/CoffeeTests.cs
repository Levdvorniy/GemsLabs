using Lab4Library;

namespace CoffeeMachines.Tests
{
    public class CoffeeTests
    {
        private const int _capacity = 1000;
        [Fact]
        public void CreateCoffee_Espresso_Success()
        {
            //Arrage
            var coffeeMachine = new CoffeeMachine(_capacity);
            Coffee coffee = new Coffee();
            //Act
            coffeeMachine.LoadWater(500);
            coffeeMachine.LoadMilk(500);
            coffeeMachine.LoadBeans(500);
            coffee = coffeeMachine.Brew(RecipeName.Espresso);
            //Assert
            Assert.Equal(RecipeName.Espresso, coffee.Recipe);
        }
    }
}