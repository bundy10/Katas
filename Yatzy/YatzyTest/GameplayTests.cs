using Yatzy;

namespace YatzyTest;

public class GameplayTests
{
    private readonly Gameplay _gameplay;
    
    public GameplayTests()
    {
        _gameplay = new Gameplay();
    }
    
    [Fact]
    public void GivenRollIsCalled_ThenReturnAListOfFiveNumbers()
    {
        //Arrange
        var numOfRolls = 0;
        
        //Act
        numOfRolls = _gameplay.Roll().Count;

        //Assert
        Assert.Equal(5, numOfRolls);
    }
    
    [Fact]
    public void GivenRollIsCalled_ThenReturnAListOfNumbersFromOneToSix()
    {
        //Arrange
        
        
        //Act
        var roll = _gameplay.Roll();

        //Assert
        Assert.Collection(roll, 
            diceRoll => Assert.InRange(diceRoll, 1, 6),
            diceRoll => Assert.InRange(diceRoll, 1, 6),
            diceRoll => Assert.InRange(diceRoll, 1, 6),
            diceRoll => Assert.InRange(diceRoll, 1, 6),
            diceRoll => Assert.InRange(diceRoll, 1, 6)
            );
    }
}