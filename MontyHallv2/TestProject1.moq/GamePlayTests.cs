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
    private static readonly Mock<IGameMode> MockGameMode = new();
    private readonly GamePlay _gamePlay = new(MockGameMode.Object);
    private readonly Host _host = new();
    
    [Fact]
    public void GivenPlayGameIsCalled_WhenThreeDoorObjectsAreCreated_ThenPlayerPromptedToChooseADoor()
    {
        // Arrange
        // create a new gamePlay object
        // create a new gameMode
        // give strategies to gameMode
        // var strategy = new ToStay();
        // var gameMode = new Simulator(strategy);

        MockGameMode.Setup(gameMode => gameMode.PlayerChooseDoor(It.IsAny<List<Door>>()))
            .Callback<List<Door>>(doors => doors[0].PlayerPickedDoor())
            .Verifiable();
        // .Return to expect a return from the function

        // Act
        // Call PlayGame on the gamePlay object
        _gamePlay.PlayGame();

        // Assert
        // We check if one of the three door objects has a PlayerPicked
        // check if player chooses a door
        MockGameMode.Verify();
        //mockGameMode.Verify(gameMode => gameMode.PlayerChooseDoor(It.IsAny<List<Door>>()), Times.Once);
    }
    
    [Fact]
    public void GivenPlayGameIsCalled_WhenPlayerChoosesADoor_ThenHostOpensADoor()
    {
        //Arrange
        MockGameMode.Setup(gameMode => gameMode.PlayerSwitchOrStayDoor(It.IsAny<List<Door>>()))
            .Callback<List<Door>>(doors => doors[0].PlayerPickedDoor())
            .Verifiable();
        
        //Act
        _gamePlay.PlayGame();

        //Assert
        MockGameMode.Verify();
    }

    [Fact]
    public void GivenPlayGameIsCalled_WhenHostOpensADoor_ThenPlayerPromptedToSwitchToADoor()
    {
        //Arrange
        MockGameMode.Setup(gameMode => gameMode.PlayerSwitchOrStayDoor(It.IsAny<List<Door>>()))
            .Callback<List<Door>>(doors => doors[0].PlayerPickedDoor())
            .Verifiable();
        
        //Act
        _gamePlay.PlayGame();

        //Assert
        MockGameMode.Verify();
    }
    

    

}