using MontyHallV2.DoorCreation;

namespace MontyHallv2.GameShowStaff;

public class GameMaster
{
    private readonly Random _random = new Random();
    
    
    public List<Door> CreateDoorsAndInjectCarToRandomDoor()
    {
        var doors = Enumerable.Range(1, Door.GetCount())
            .Select(_ => new Door())
            .ToList();
        
        doors[_random.Next(doors.Count)].InjectCarToDoor();
        return doors;
    } 
}