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
    [Fact]
    public void GivenPlayGameIsCalled_WhenThreeDoorObjectsAreCreated_ThenPlayerPromptedToChooseADoor()
    {
        // Arrange
        // create a new gamePlay object
        // create a new gameMode
        // give strategies to gameMode
        // var strategy = new ToStay();
        // var gameMode = new Simulator(strategy);
        var mockGameMode = new Mock<IGameMode>();
        var gamePlay = new GamePlay(mockGameMode.Object);

        mockGameMode.Setup(gameMode => gameMode.PlayerChooseDoor(It.IsAny<List<Door>>()))
            .Callback<List<Door>>(doors => doors[0].PlayerPickedDoor())
            .Verifiable();
        // .Return to expect a return from the function

        // Act
        // Call PlayGame on the gamePlay object
        gamePlay.PlayGame();

        // Assert
        // We check if one of the three door objects has a PlayerPicked
        // check if player chooses a door
        mockGameMode.Verify();
        //mockGameMode.Verify(gameMode => gameMode.PlayerChooseDoor(It.IsAny<List<Door>>()), Times.Once);
    }
}