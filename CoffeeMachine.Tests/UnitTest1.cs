using Lab4Library;

namespace CoffeeMachines.Tests
{
    public class UnitTest1
    {
        private const int _capasity = 1000;
        [Fact]
        public void CreateCoffeeMachine_NoInputData_Success()
        {
            //Arrage
            var coffeeMachine = new CoffeeMachine(_capasity);
            //Act
            Coffee coffee = new Coffee();
            coffee.Recipe = RecipeName.Espresso;
            //Assert
            Assert.Equal(RecipeName.Espresso, coffee.Recipe);
        }

        [Fact]
        public void LoadProductsInCoffeeMachine_Capasity_Success()
        {
            //Arrage
            var coffeeMachine = new CoffeeMachine(_capasity);
            //Act
            coffeeMachine.LoadWater(_capasity);
            coffeeMachine.LoadMilk(_capasity);
            coffeeMachine.LoadBeans(_capasity);
            //Assert
            Assert.Equal(_capasity, coffeeMachine.GetWaterLevel());
        }

        [Fact]
        public void CreateContainer_IncorrectData_NotSuccess()
        {
            //Arrage
            var coffeeMachine = new CoffeeMachine(_capasity);

            //Act + Assert
            Assert.Throws<ArgumentException>(() => new Container(-1));
        }


        [Theory]
        [InlineData(-1)]
        [InlineData(1001)]
        public void LoadProductsInCoffeeMachine_IncorrectData_NotSuccess(int value)
        {
            //Arrage
            var coffeeMachine = new CoffeeMachine(_capasity);
            
            //Act + Assert
            Assert.Throws<ArgumentException>(() => coffeeMachine.LoadWater(value));
        }

        [Fact]
        public void CreateCoffee_Espresso_Success()
        {
            //Arrage
            var coffeeMachine = new CoffeeMachine(_capasity);
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