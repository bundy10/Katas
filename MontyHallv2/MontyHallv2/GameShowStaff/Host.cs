using MontyHallV2.DoorCreation;

namespace MontyHallv2.GameShowStaff;

public class Host
{
    private readonly Random _random = new Random();
    private int _prizeInjector;
    
    public int InjectPrizeToDoor(List<Door> doors)
    {
        _prizeInjector = _random.Next(doors.Count);
        return _prizeInjector;
    }

    public List<Door> HostOpensADoor(List<Door> doors)
    {
        doors.First(door => door.HasCarOrPlayerPicked() != true).OpeningDoor();
        return doors;
    }
}