using MontyHallV2.DoorCreation;

namespace MontyHallv2.Contestant;

public class Player
{
    private readonly Random _random = new Random();
    
    public void ChooseDoor(List<Door> doors)
    {
        doors[_random.Next(doors.Count)].PlayerPickedDoor();
    }
}