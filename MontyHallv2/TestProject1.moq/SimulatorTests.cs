using MontyHallV2.DoorCreation;
using MontyHallV2.GameModes;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;
using Moq;

namespace TestProject1.moq;

public class SimulatorTests
{
    private static readonly Mock<IStrategy> Strategy = new();
    private readonly Simulator _simulator = new(Strategy.Object);

    [Fact]
    public void GivenPlayerSwitchOrStayDoorIsCalled_ThenSimulationPlayerShouldBePromptedToSwitchOrStayAtADoor()
    {
        //Arrange
        Strategy.Setup(simPlayer => simPlayer.ToSwitchOrStay(It.IsAny<List<Door>>())).Verifiable();
        
        //Act
        _simulator.PlayerSwitchOrStayDoor(It.IsAny<List<Door>>());
        
        //Assert
        Strategy.Verify();
    }

    [Fact]
    public void GivenPlayerChooseDoorIsCalled_WhenSimulatorPlayerChoosesDoor_ThenADoorWillHaveBeenPicked()
    {
        //Arrange
        var doors = GameMaster.CreateDoorsAndInjectCarToRandomDoor();

        //Act
        _simulator.PlayerChooseDoor(doors);
        var result = doors.Any(door => door.HasPlayerPicked());

        //Assert
        Assert.True(result);

    }
}