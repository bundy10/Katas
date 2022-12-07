using System.Xml.Serialization;
using MontyHallV2.DoorCreation;
using MontyHallV2.GameModes;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;
using MontyHallv2.Strategies;
using Moq;

namespace TestProject1.moq;

public class GamePlayTests

{
    private readonly Mock<IGameMode> _mockGameMode;
    private readonly SimGamePlay _simGamePlay;
    private readonly Mock<IRandom> _mockRandom;

    public GamePlayTests()
    {
        _mockGameMode = new Mock<IGameMode>();
        _mockRandom = new Mock<IRandom>();
        _simGamePlay = new SimGamePlay(_mockGameMode.Object, _mockRandom.Object);
    }

    [Fact]
    public void GivenPlayGameIsCalled_WhenThreeDoorObjectsAreCreated_ThenPlayerPromptedToChooseADoor()
    {
        // Arrange
        // create a new gamePlay object
        // create a new gameMode
        // give strategies to gameMode
        // var strategy = new ToStay();
        // var gameMode = new Simulator(strategy);

        _mockGameMode.Setup(gameMode => gameMode.PlayerChooseDoor(It.IsAny<List<Door>>()))
            .Callback<List<Door>>(doors => doors[0].PlayerPickedDoor())
            .Verifiable();
        // .Return to expect a return from the function

        // Act
        // Call PlayGame on the gamePlay object
        _simGamePlay.PlayGame();

        // Assert
        // We check if one of the three door objects has a PlayerPicked
        // check if player chooses a door
        _mockGameMode.Verify();
        //mockGameMode.Verify(gameMode => gameMode.PlayerChooseDoor(It.IsAny<List<Door>>()), Times.Once);
    }


    [Fact]
    public void GivenPlayGameIsCalled_WhenHostOpensADoor_ThenPlayerPromptedToSwitchToADoor()
    {
        //Arrange
        _mockGameMode.Setup(gameMode => gameMode.PlayerChooseDoor(It.IsAny<List<Door>>()))
            .Callback<List<Door>>(doors => doors[0].PlayerPickedDoor());

        _mockGameMode.Setup(gameMode => gameMode.PlayerSwitchOrStayDoor(It.IsAny<List<Door>>()))
            .Verifiable();
        
        //Act
        _simGamePlay.PlayGame();

        //Assert
        _mockGameMode.Verify();
    }
    
    
    [Fact]
    public void GivenAPlayerHasPickedADoor_WhenThePlayerIsPromptedToSwitchOrStayDoor_ThenADoorShouldBeOpenedByTheHost()
    {
        //Arrange
        var isADoorOpened = false;
        
        _mockGameMode.Setup(gameMode => gameMode.PlayerChooseDoor(It.IsAny<List<Door>>()))
            .Callback<List<Door>>(doors => doors[0].PlayerPickedDoor());

        _mockGameMode.Setup(gameMode => gameMode.PlayerSwitchOrStayDoor(It.IsAny<List<Door>>()))
            .Callback<List<Door>>(doors => isADoorOpened = doors.Any(door => door.IsDoorOpened()));

        //Act
        _simGamePlay.PlayGame();

        //Assert
        Assert.True(isADoorOpened);
    }
    
    [Fact]
    public void GivenPlayGameIsCalled_WhenTheDoorWithACarIsPickedByAPlayer_ThenReturnTrue()
    {
        //Arrange
        _mockRandom.Setup(num => num.GetNumberBetweenRange(It.IsAny<int>(), It.IsAny<int>())).Returns(2);
        _mockGameMode.Setup(gameMode => gameMode.PlayerChooseDoor(It.IsAny<List<Door>>()))
            .Callback<List<Door>>(doors => doors[2].PlayerPickedDoor());

        Assert.True(_simGamePlay.PlayGame());
    }
    
    [Fact]
    public void GivenPlayGameIsCalled_WhenTheDoorWithACarIsNotPickedByAPlayer_ThenReturnFalse()
    {
        
        _mockRandom.Setup(num => num.GetNumberBetweenRange(It.IsAny<int>(), It.IsAny<int>())).Returns(2);
        _mockGameMode.Setup(gameMode => gameMode.PlayerChooseDoor(It.IsAny<List<Door>>()))
            .Callback<List<Door>>(doors => doors[1].PlayerPickedDoor());
        
        Assert.False(_simGamePlay.PlayGame());
    }
    
}