using MontyHallv2.Contestant;
using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;

namespace MontyHallV2.GameModes;

public class Simulator : IGameMode
{
    private readonly SimulationPlayer _simulationPlayer = new();
    private readonly IStrategy _strategy;

    public Simulator(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void PlayerChooseDoor(List<Door> doors)
    {
        _simulationPlayer.ChooseDoor(doors);
    }

    public void PlayerSwitchOrStayDoor(List<Door> doors)
    {
        _simulationPlayer.ChooseSwitchOrStay(_strategy, doors);
    }
}