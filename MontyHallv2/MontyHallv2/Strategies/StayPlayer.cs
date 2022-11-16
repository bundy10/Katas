using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.Strategies;

public class StayPlayer : IPlayer
{
    private readonly Random _random = new Random();
    private const bool SwitchOrNot = false;

    public void ChooseDoor(List<Door> doors)
    {
        doors[_random.Next(doors.Count)].PlayerPickedDoor();
    }

    public void SwitchDoor(List<Door> doors)
    {
    }

    public bool IsPlayerGoingToSwitch()
    {
        return SwitchOrNot;
    }
}