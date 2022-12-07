using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;
using MontyHallv2.Random;

namespace MontyHallv2.Contestant;

public class SimulationPlayer
{
    private readonly IRandom _random = new RandomNum();

    public void ChooseDoor(List<Door> doors)
    {
        doors[_random.GetNumberBetweenRange(0, doors.Count)].PlayerPickedDoor();
    }

    public void ChooseSwitchOrStay(IStrategy strategy, List<Door> doors)
    {
        strategy.ToSwitchOrStay(doors);
    }
}