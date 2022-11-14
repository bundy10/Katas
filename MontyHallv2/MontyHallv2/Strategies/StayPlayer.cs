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

    public void ChooseDoor(List<Door> doors)
    {
        _choice = _random.Next(doors.Count);
    }

    public void SwitchDoor(List<Door> doors)
    {
        throw new NotImplementedException();
    }
}