using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.Strategies;

public class StayPlayer : IPlayer
{
    private readonly Random _random = new Random();
    private int _choice;

    public int GetChoice()
    {
        return _choice;
    }

    public List<Door> ChooseDoor(List<Door> doors)
    {
        doors[_random.Next(doors.Count)].PlayerPickedDoor();
        return doors;
    }

    public void SwitchDoor(List<Door> doors, int playerChoice, int hostDoor)
    {
        _choice = _random.Next(doors.Count);
    }
}