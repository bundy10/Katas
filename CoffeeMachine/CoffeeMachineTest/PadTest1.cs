
using CoffeeMachine;
using CoffeeMachine.Drink;

namespace CoffeeMachineTest;

public class PadTest1
{
    private readonly Pad _pad = new();
    
    
    [Fact]
    public void GivenSendOrderIsCalled_WhenAStringIsGiven_ThenReturnTheString()
    {
        //Arrange
        var order = "Coffee";

        //Act
        var result = _pad.GetOrder(order);

        //Assert
        Assert.IsType<string>(result);
    }
    
    [Fact]
    public void GivenSendOrderIsCalled_WhenADrinkIsPassed_ThenReturnTheDrink()
    {
        //Arrange
        var order = new Coffee(2);

        //Act
        

        //Assert
        
    }
    
}