using MontyHallv2.Contestant;
using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;
using MontyHallv2.Random;
using MontyHallv2.Strategies;
using Moq;

namespace TestProject1.moq;

public class SimulationPlayerTest
{
    private readonly SimulationPlayer _simulationPlayer;
    private readonly List<Door> _doors;
    private readonly IStrategy _strategy;
    private readonly GameMaster _gameMaster = new(new RandomNum());

    public SimulationPlayerTest()
    {
        // Arrange
        _doors = _gameMaster.CreateDoorsAndInjectCarToRandomDoor();
        _simulationPlayer = new SimulationPlayer();
        _strategy = new ToSwitch();
    }
    
    [Fact]
    public void GivenChooseDoorIsCalled_WhenDoorsAreAvailable_ThenADoorIsChosen()
    {
        
        // Act
        _simulationPlayer.ChooseDoor(_doors);
        var allPickedDoors = _doors.FindAll(door => door.HasPlayerPicked());
        var result = allPickedDoors.Count;

        
        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void GivenChooseSwitchOrStayIsCalled_WhenADoorIsPicked_ThenPlayerSwitchesToAnUnPickedDoor()
    {
        // Act
        _simulationPlayer.ChooseDoor(_doors);
        var oldPickedDoor = _doors.First(door => door.HasPlayerPicked());
        _simulationPlayer.ChooseSwitchOrStay(_strategy, _doors);
        var newDoorPicked = _doors.First(door => door.HasPlayerPicked());
        bool result = oldPickedDoor.HasPlayerPicked() != true && newDoorPicked.HasPlayerPicked();

        // Assert
        Assert.True(result);
        
    }
}