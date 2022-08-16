using Lab4Library;

namespace CoffeeMachines.Tests
{
    public class ContainerTests
    {
        private const int _capacity = 1000;
        
        [Fact]
        public void CreateContainer_CorrectData_Success()
        {
            //Arrage + Act
            var container = new Container(1000);
            //Assert
            Assert.Equal(1000,container.GetCapasity());
        }

        [Fact]
        public void CreateContainer_IncorrectData_Failure()
        {
            //Arrage
            var coffeeMachine = new CoffeeMachine(_capacity);

            //Act + Assert
            Assert.Throws<ArgumentException>(() => new Container(-1));
        }
    }
}