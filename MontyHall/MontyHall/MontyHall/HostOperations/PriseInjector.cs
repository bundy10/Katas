using MontyHall.DoorCreation;

namespace MontyHall.HostOperations;

public class PriseInjector
{
    private int _priseDoor;
    private readonly Random _rand = new Random();
    
    public int InjectPriseToRandomDoor(List<int> doors)
    {
        _rand.Next(doors.Count);
        return _priseDoor;
    }
}