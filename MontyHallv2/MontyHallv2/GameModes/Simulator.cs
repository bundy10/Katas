using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;

namespace MontyHallV2.GameModes;

public class Simulator
{
    private List<Door>? _doors;
    private readonly Host _theHost = new Host();
    private readonly GameMaster _gameMaster = new GameMaster();


    public bool Simulate(IPlayer player)
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