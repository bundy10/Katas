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
    private readonly SimulatorGame _simulatorGame;

    public SimulatorTests()
    {
        _strategy = new Mock<IStrategy>();
        _simulatorGame = new SimulatorGame(_strategy.Object);
    }

    [Fact]
    public void GivenPlayerSwitchOrStayDoorIsCalled_ThenSimulationPlayerShouldBePromptedToSwitchOrStayAtADoor()
    {
        //Arrange
        _strategy.Setup(simPlayer => simPlayer.ToSwitchOrStay(It.IsAny<List<Door>>())).Verifiable();
        
        //Act
        _simulatorGame.PlayerSwitchOrStayDoor(It.IsAny<List<Door>>());
        
        //Assert
        _strategy.Verify();
    }

    [Fact]
    public void
        GivenPlayerSwitchOrStayDoorIsCalled_WhenTwoDoorsAreEitherPickedAlreadyOrOpened_ThenTheLatterDoorWillBePicked()
    {
        var gameMaster = new GameMaster(new RandomNum());
        var doors = gameMaster.GetDoorsIncludingCarDoors();
        doors[0].PlayerPickedDoor();
        doors[1].PlayerPickedDoor();
        
        _strategy.Setup(simPlayer => simPlayer.ToSwitchOrStay(doors))
            .Callback<List<Door>>(door => door[2].PlayerPickedDoor());
        
        _simulatorGame.PlayerSwitchOrStayDoor(doors);
        
        Assert.True(doors[2].HasPlayerPicked());
    }

    [Fact]
    public void GivenPlayerChooseDoorIsCalled_WhenSimulatorPlayerChoosesDoor_ThenADoorWillHaveBeenPicked()
    {
        //Arrange
        var gameMaster = new GameMaster(new RandomNum());
        var doors = gameMaster.GetDoorsIncludingCarDoors();

        //Act
        _simulatorGame.PlayerChooseDoor(doors);
        var result = doors.Any(door => door.HasPlayerPicked());

        //Assert
        Assert.True(result);

    }
}