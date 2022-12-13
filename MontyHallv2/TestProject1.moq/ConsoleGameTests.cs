using MontyHallV2.DoorCreation;
using MontyHallV2.GameModes;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;
using MontyHallv2.Random;
using Moq;

namespace TestProject1.moq;

public class ConsoleGameTests
{
    private List<Door> _doors;
    private readonly ConsoleGame _consoleGame = new();
    private const int CarDoorIndex = 0;
    private const string InputFirstDoor = "1";
    private const int SecondDoorIndex = 1;
    private const int ThirdDoorIndex = 2;

    public ConsoleGameTests()
    {
        //Assert
        _doors = new GameMaster(new RandomNum()).GetDoorsIncludingCarDoors();
    }

    [Fact]
    public void GivenPlayerChooseDoorIsCalled_WhenUserIsPromptedToOpenADoor_ThenADoorWillBePicked()
    {
        //Arrange
        var stringReader = new StringReader(InputFirstDoor);
        Console.SetIn(stringReader);
        const int expectedOneDoorToBePicked = 1;
        
        //Act
        _consoleGame.PlayerChooseDoor(_doors);
        var numOfDoorsPicked = _doors.FindAll(door => door.HasPlayerPicked()).Count;
        
        //Assert
        Assert.Equal(expectedOneDoorToBePicked, numOfDoorsPicked);
    }
    
    [Fact]
    public void GivenPlayerChooseDoorIsCalled_WhenDoorsAreAvailable_ThenUserIsPromptedToOpenADoor()
    {
        //Arrange
        const string inputDoorToPickAndYesToSwitch = $"{InputFirstDoor}\ny";
        var stringReader = new StringReader(inputDoorToPickAndYesToSwitch);
        Console.SetIn(stringReader);

        //Act
        _consoleGame.PlayerChooseDoor(_doors);
        _consoleGame.PlayerSwitchOrStayDoor(_doors);
        var doorPickedAfterSwitching = _doors.FindIndex(door => door.HasPlayerPicked());

        //Assert
        Assert.InRange(doorPickedAfterSwitching, SecondDoorIndex,ThirdDoorIndex);
    }
    
    [Fact]
    public void GivenGetGameOutComeIsCalled_WhenAPlayerHasPickedTheCarDoorAndHasOptedNotToSwitch_ThenThePlayerHasWonTheCar()
    {
        //Arrange
        var mockRandom = new Mock<IRandom>();
        var gameMaster = new GameMaster(mockRandom.Object);

        const string inputDoorToPickAndNoToSwitch = $"{InputFirstDoor}\nn";
        var stringReader = new StringReader(inputDoorToPickAndNoToSwitch);
        Console.SetIn(stringReader);
        mockRandom.Setup(num => num.GetNumberBetweenRange(It.IsAny<int>(), It.IsAny<int>())).Returns(CarDoorIndex);
        _doors = gameMaster.GetDoorsIncludingCarDoors();
    
        //Act
        _consoleGame.PlayerChooseDoor(_doors);
        _consoleGame.PlayerSwitchOrStayDoor(_doors);
        var winOrLoss = _consoleGame.GetGameOutCome(_doors);

        //Assert
        Assert.True(winOrLoss);
    }

}