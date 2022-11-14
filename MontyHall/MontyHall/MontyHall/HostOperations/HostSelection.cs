using MontyHall.Interfaces;

namespace MontyHall.HostOperations;

public class HostSelection : IGameAdmin
{
    private int _host0Injection;
    private readonly Random _rand = new Random();

    public int InjectToRandomDoor(List<int> doors)
    {
        _host0Injection = _rand.Next(doors.Count);
        return _host0Injection;
        //testing change
    }
}
