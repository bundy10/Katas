using MontyHallV2.DoorCreation;
using MontyHallV2.GameModes;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;
using MontyHallv2.Random;
using Moq;

namespace TestProject1.moq;

public class SimulatorTests
{
    private readonly Mock<IStrategy> _strategy;
    private readonly Simulator _simulator;

    public SimulatorTests()
    {
        _strategy = new Mock<IStrategy>();
        _simulator = new Simulator(_strategy.Object);
    }

    [Fact]
    public void GivenPlayerSwitchOrStayDoorIsCalled_ThenSimulationPlayerShouldBePromptedToSwitchOrStayAtADoor()
    {
        //Arrange
        _strategy.Setup(simPlayer => simPlayer.ToSwitchOrStay(It.IsAny<List<Door>>())).Verifiable();
        
        //Act
        _simulator.PlayerSwitchOrStayDoor(It.IsAny<List<Door>>());
        
        //Assert
        _strategy.Verify();
    }

    [Fact]
    public void GivenPlayerChooseDoorIsCalled_WhenSimulatorPlayerChoosesDoor_ThenADoorWillHaveBeenPicked()
    {
        //Arrange
        var gameMaster = new GameMaster(new RandomNum());
        var doors = gameMaster.CreateDoorsAndInjectCarToRandomDoor();

        //Act
        _simulator.PlayerChooseDoor(doors);
        var result = doors.Any(door => door.HasPlayerPicked());

        //Assert
        Assert.True(result);

    }
}