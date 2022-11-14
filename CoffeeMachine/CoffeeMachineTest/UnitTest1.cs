using CoffeeMachine.Barista;

namespace CoffeeMachineTest;

public class UnitTest1
{
    [Fact]
    public void GivenACommandIsSent_WhenGetCommandIsCalled_ThenReturnCommandString()
    {
        //arrange
        const string command = "tea";
        var barista = new DrinkMaker();

        //act
        barista.SendCommand(command);
        var drink = barista.GetDrink();

        //assert
        Assert.Equal(command, drink);
    }
}