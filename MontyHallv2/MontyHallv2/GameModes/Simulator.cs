using MontyHallv2.Contestant;
using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;

namespace MontyHallV2.GameModes;

public class Simulator : IGameMode
{
    private List<Door>? _doors;
    private readonly SimulationPlayer _simulationPlayer = new();
    
    public bool PlayGame( IStrategy strategy)
    {
        _doors = GameMaster.CreateDoorsAndInjectCarToRandomDoor();
        _simulationPlayer.ChooseDoor(_doors);
        Host.HostOpensADoor(_doors);
        strategy.ToSwitchOrStay(_doors);
        return _doors.First(door => door.HasPlayerPicked()).HasWonTheCarOrNot();
    }
}