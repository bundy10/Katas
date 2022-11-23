using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.GameShowStaff;

public static class GameMaster
{
    private static readonly Random Random = new();
    
    public static List<Door> CreateDoorsAndInjectCarToRandomDoor()
    {
        var doors = Enumerable.Range(1, 3)
            .Select(_ => new Door())
            .ToList();
        
        doors[Random.Next(doors.Count)].InjectCarToDoor();
        return doors;
    } 
}