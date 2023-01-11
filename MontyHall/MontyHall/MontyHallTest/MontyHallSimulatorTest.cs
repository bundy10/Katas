using MontyHall.GameMode;
using MontyHall.HostOperations;
using MontyHall.Strategies;

namespace MontyHallTest;

public class UnitTest1
{
    [Fact]
    public void GivenParametersWhenSimulateIsCalledThenReturnWinOrLossString()
    {
        //arrange
        var winOrLose = new Simulate(); 
        

        //act
        var actualResult = winOrLose.Simulator(3, new StayPlayer(), new HostSelection(), new PrizeInjector());

        //assert
        Assert.IsType<string>(actualResult);
    }
}