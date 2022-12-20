using MontyHallv2.DoorCreation;
using MontyHallv2.GameModes;
using MontyHallv2.Validation;

namespace TestProject1.moq;

public class PlayerChoiceValidatorTests
{
    private readonly ConsoleGame _consoleGame = new();

    [Fact]
    public void GivenPLayerChooseDoorIsCalled_WhenUserDoorChoiceIsInvalid_ThenValidatorWillReturnFalse()
    {
        //Arrange
        var stringReader = new StringReader("4");
        Console.SetIn(stringReader);
        
        //Act
        var userDoorSelection = _consoleGame.GetDoorSelectionFromUser();
        var isUserDoorSelectionValid = PlayerChoiceValidator.ValidateUserDoorSelection(userDoorSelection);
        
        //Assert
        Assert.False(isUserDoorSelectionValid);
    }

    [Fact]
    public void GivenPLayerSwitchOrStayDoorIsCalled_WhenUserInputIsInvalid_ThenValidatorWillReturnFalse()
    {
        //Arrange
        var stringReader = new StringReader("c");
        Console.SetIn(stringReader);
        
        //Act
        var userSwitchOrStayChoice = _consoleGame.GetSwitchOrStayChoiceFromUser();
        var isUserSwitchOrStayChoiceIsValid = PlayerChoiceValidator.ValidateUserSwitchOrStayChoice(userSwitchOrStayChoice);
        
        //Assert
        Assert.False(isUserSwitchOrStayChoiceIsValid);
    }
}
