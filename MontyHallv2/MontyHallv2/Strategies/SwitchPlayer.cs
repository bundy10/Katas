using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.Strategies;

public class SwitchPlayer : IPlayer
{
    private readonly Random _random = new Random();

    public List<Door> ChooseDoor(List<Door> doors)
    {
        doors[_random.Next(doors.Count)].PlayerPickedDoor();
        return doors;
    }

    public void SwitchDoor(List<Door> doors, int playerChoice, int hostDoor)
    {
        
    }
}