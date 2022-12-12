
using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;
using MontyHallv2.Random;

namespace MontyHallV2.GameModes;

public class SimulatorGame : IGameMode
{
    private readonly IStrategy _strategy;
    private readonly IRandom _random;

    public SimulatorGame(IStrategy strategy)
    {
        _strategy = strategy;
        _random = new RandomNum();
    }

    public void PlayerChooseDoor(List<Door> doors)
    {
        doors[_random.GetNumberBetweenRange(0, doors.Count)].PlayerPickedDoor();
    }

    public void PlayerSwitchOrStayDoor(List<Door> doors)
    {
        _strategy.ToSwitchOrStay(doors);
    }

    public bool GetGameOutCome(List<Door> doors)
    {
        return doors.First(door => door.HasPlayerPicked()).HasCar();
    }
}