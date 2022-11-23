using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.Strategies;

public class SwitchPlayer : IPlayer
{
    private readonly Random _random = new Random();
    private const bool SwitchOrNot = true;

    public void ChooseDoor(List<Door> doors)
    {
        doors[_random.Next(doors.Count)].PlayerPickedDoor();
    }

    public void SwitchDoor(List<Door> doors)
    {
        doors.RemoveAll(door => door.HasPlayerPicked());
        doors.First(door => door.IsDoorOpened() == false).PlayerPickedDoor();
    }
    public bool IsPlayerGoingToSwitch()
    {
        return SwitchOrNot;
    }
}