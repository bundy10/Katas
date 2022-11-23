using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.Contestant;

public class SimulationPlayer
{
    private readonly Random _random = new Random();
    
    public void ChooseDoor(List<Door> doors)
    {
        doors[_random.Next(doors.Count)].PlayerPickedDoor();
    }
}