using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.Strategies;

public class SwitchPlayer : IPlayer
{
    private readonly Random _random = new Random();
    private const bool SwitchOrNot = true;

    public List<Door> ChooseDoor(List<Door> doors)
    {
        doors[_random.Next(doors.Count)].PlayerPickedDoor();
        return doors;
    }

    public List<Door> SwitchDoor(List<Door> doors)
    {
        //doors.First(door => door.HasPlayerPicked()).HasWonTheCar();
        return doors;
    }
    public bool IsPlayerGoingToSwitch()
    {
        return SwitchOrNot;
    }
    
}