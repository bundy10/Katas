using MontyHallv2.DoorCreation;
using MontyHallv2.GameModes;
using MontyHallv2.GameShowStaff;
using MontyHallv2.Interfaces;
using MontyHallv2.Random;
using Moq;

namespace TestProject1.moq;

public class ConsoleGameTests
{
    private readonly List<Door> _doors;
    private readonly ConsoleGame _consoleGame = new();
    private const int CarDoor = 0;

    public ConsoleGameTests()
    {
        //Assert
        _doors = Enumerable.Range(1, 3)
            .Select(_ => new Door())
            .ToList();
        
        _doors[0].InjectCarToDoor();
    }

    [Fact]
    public void GivenPlayerChooseDoorIsCalled_WhenUserIsPromptedToOpenADoor_ThenADoorWillBePicked()
    {
        //Arrange
        var stringReader = new StringReader("1");
        Console.SetIn(stringReader);
        const int expectedExactlyOneDoorToBePicked = 1;
        
        //Act
        _consoleGame.PlayerChooseDoor(_doors);
        var numOfDoorsPicked = _doors.FindAll(door => door.HasPlayerPicked()).Count;
        
        //Assert
        Assert.Equal(expectedExactlyOneDoorToBePicked, numOfDoorsPicked);
    }
    
    [Fact]
    public void GivenPlayerSwitchOrStayDoorIsCalled_WhenADoorIsAlreadyPicked_ThenThatDoorWillBeUnpicked()
    {
        //Arrange
        const string inputDoorToPickAndYesToSwitch = "1\ny";
        var stringReader = new StringReader(inputDoorToPickAndYesToSwitch);
        Console.SetIn(stringReader);

        //Act
        _consoleGame.PlayerChooseDoor(_doors);
        _consoleGame.PlayerSwitchOrStayDoor(_doors);
        var unpickedDoor = _doors[0].HasPlayerPicked();

        //Assert
        Assert.False(unpickedDoor);
    }
    
    [Fact]
    public void GivenPlayerSwitchOrStayDoorIsCalled_WhenADoorIsAlreadyPicked_ThenOneOfTheOtherDoorsWillBePicked()
    {
        //Arrange
        const string inputDoorToPickAndYesToSwitch = "1\ny";
        var stringReader = new StringReader(inputDoorToPickAndYesToSwitch);
        Console.SetIn(stringReader);

        //Act
        _consoleGame.PlayerChooseDoor(_doors);
        _consoleGame.PlayerSwitchOrStayDoor(_doors);
        var pickedDoorAfterSwitch = _doors[1].HasPlayerPicked() || _doors[2].HasPlayerPicked();

        //Assert
        Assert.True(pickedDoorAfterSwitch);
    }

    [Fact]
    public void GivenGetGameOutComeIsCalled_WhenAPlayerHasPickedTheCarDoorAndHasOptedNotToSwitch_ThenThePlayerHasWonTheCar()
    {
        //Arrange
        const string inputDoorToPickAndNoToSwitch = "1\nn";
        var stringReader = new StringReader(inputDoorToPickAndNoToSwitch);
        Console.SetIn(stringReader);

        //Act
        _consoleGame.PlayerChooseDoor(_doors);
        _consoleGame.PlayerSwitchOrStayDoor(_doors);
        var hasWon = _consoleGame.GetGameOutCome(_doors);

        //Assert
        Assert.True(hasWon);
    }
    
    [Fact]
    public void GivenGetGameOutComeIsCalled_WhenAPlayerHasPickedTheCarDoorAndHasOptedToSwitch_ThenThePlayerHasNotWonTheCar()
    {
        //Arrange
        const string inputDoorToPickAndNoToSwitch = "1\ny";
        var stringReader = new StringReader(inputDoorToPickAndNoToSwitch);
        Console.SetIn(stringReader);

        //Act
        _consoleGame.PlayerChooseDoor(_doors);
        _consoleGame.PlayerSwitchOrStayDoor(_doors);
        var hasWon = _consoleGame.GetGameOutCome(_doors);

        //Assert
        Assert.False(hasWon);
    }
    
    [Fact]
    public void GivenADoorIsOpened_WhenAPlayerHasPickedTheCarDoorAndHasOptedToSwitch_ThenThePlayerCannotSwitchToTheOpenedDoor()
    {
        //Arrange
        const string inputDoorToPickAndNoToSwitch = "1\ny";
        var stringReader = new StringReader(inputDoorToPickAndNoToSwitch);
        Console.SetIn(stringReader);
        _doors[1].OpeningDoor();

        //Act
        _consoleGame.PlayerChooseDoor(_doors);
        _consoleGame.PlayerSwitchOrStayDoor(_doors);
        var onlyDoorAvailableToBePickedAfterSwitch = _doors[2].HasPlayerPicked();

        //Assert
        Assert.True(onlyDoorAvailableToBePickedAfterSwitch);
    }

}