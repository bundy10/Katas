using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;

namespace MontyHallV2.GameModes;

public class Simulator
{
    private List<Door>? _doors;
    private readonly GameMaster _gameMaster = new();
    
    public bool Simulate(IPlayer player, IStrategy strategy)
    {
        _doors = _gameMaster.CreateDoorsAndInjectCarToRandomDoor();
        player.ChooseDoor(_doors);
        Host.HostOpensADoor(_doors);
        if (player.IsPlayerGoingToSwitch())
        {
            player.SwitchDoor(_doors);
        }
        
        return _doors.First(door => door.HasPlayerPicked()).HasWonTheCarOrNot();
    }
}