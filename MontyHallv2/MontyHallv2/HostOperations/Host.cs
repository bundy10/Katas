using MontyHallV2.DoorCreation;

namespace MontyHallv2.HostOperations;

public class Host
{
    private readonly Random _random = new Random();
    private int _prizeInjector;
    
    public int InjectPrizeToDoor(List<Door> doors)
    {
        _prizeInjector = _random.Next(doors.Count);
        return _prizeInjector;
    }

    public int HostOpensADoor(int prizeDoor, int playerChoiceOfDoor)
    {
        var doorsAvailable = Enumerable.Range(0, 3).Where(a => a != prizeDoor && a != playerChoiceOfDoor).ToArray();
        return doorsAvailable[0];
    }
}