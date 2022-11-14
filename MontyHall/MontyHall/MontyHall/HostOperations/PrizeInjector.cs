using MontyHall.DoorCreation;
using MontyHall.Interfaces;

namespace MontyHall.HostOperations;

public class PrizeInjector : IGameAdmin
{
    private int _prizeDoor;
    private readonly Random _rand = new Random();
    
    public int InjectToRandomDoor(List<int> doors)
    {
        _prizeDoor = _rand.Next(doors.Count);
        return _prizeDoor;
        //testing change
    }
}