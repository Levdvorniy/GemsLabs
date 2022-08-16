using Lab4Library;

namespace CoffeeMachines.Tests
{
    public class CoffeeMachineTests
    {
        private const int _capacity = 1000;
        [Fact]
        public void CreateCoffeeMachine_NoInputData_Success()
        {
            //Arrage
            var coffeeMachine = new CoffeeMachine(_capacity);
            //Act
            Coffee coffee = new Coffee();
            coffee.Recipe = RecipeName.Espresso;
            //Assert
            Assert.Equal(RecipeName.Espresso, coffee.Recipe);
        }

        [Fact]
        public void LoadProductsInCoffeeMachine_capacity_Success()
        {
            //Arrage
            var coffeeMachine = new CoffeeMachine(_capacity);
            //Act
            coffeeMachine.LoadWater(_capacity);
            coffeeMachine.LoadMilk(_capacity);
            coffeeMachine.LoadBeans(_capacity);
            //Assert
            Assert.Equal(_capacity, coffeeMachine.GetWaterLevel());
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(1001)]
        public void LoadProductsInCoffeeMachine_IncorrectData_Failure(int value)
        {
            //Arrage
            var coffeeMachine = new CoffeeMachine(_capacity);
            
            //Act + Assert
            Assert.Throws<ArgumentException>(() => coffeeMachine.LoadWater(value));
        }
    }
}