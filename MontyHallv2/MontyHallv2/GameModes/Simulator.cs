using MontyHallv2.Contestant;
using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;

namespace MontyHallV2.GameModes;

public class Simulator
{
    private List<Door>? _doors;
    private readonly Player _player = new();
    
    public bool Simulate( IStrategy strategy)
    {
        _doors = GameMaster.CreateDoorsAndInjectCarToRandomDoor();
        _player.ChooseDoor(_doors);
        Host.HostOpensADoor(_doors);
        strategy.ToSwitchOrStay(_doors);
        return _doors.First(door => door.HasPlayerPicked()).HasWonTheCarOrNot();
    }
}