using MontyHallv2.DoorCreation;
using MontyHallv2.Interfaces;

namespace MontyHallv2.GameShowStaff;

public class GameMaster
{

    private readonly IRandom _random;

    
    public GameMaster(IRandom random)
    {
        _random = random;
    }
    
    public List<Door> GetDoorsIncludingCarDoors()
    {
        var doors = Enumerable.Range(1, 3)
            .Select(_ => new Door())
            .ToList();
        
        doors[_random.GetNumberBetweenRange(0, doors.Count - 1)].InjectCarToDoor();
        return doors;
    }
}