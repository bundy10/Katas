using MontyHall.DoorCreation;

namespace MontyHall.HostOperations;

public class PrizeInjector
{
    private int _prizeDoor;
    private readonly Random _rand = new Random();
    
    public int InjectPriseToRandomDoor(List<int> doors)
    {
        _rand.Next(doors.Count);
        return _prizeDoor;
        //testing change
    }
}