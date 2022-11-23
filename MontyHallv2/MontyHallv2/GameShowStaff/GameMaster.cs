using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.GameShowStaff;

public class GameMaster
{
    private readonly Random _random = new();
    
    public List<Door> CreateDoorsAndInjectCarToRandomDoor()
    {
        var doors = Enumerable.Range(1, 3)
            .Select(_ => new Door())
            .ToList();
        
        doors[_random.Next(doors.Count)].InjectCarToDoor();
        return doors;
    } 
}