using System.Xml.Schema;
using MontyHall.DoorCreation;
using MontyHall.Interfaces;

namespace MontyHall.Strategies;

public class StayPlayer : IPlayer
{
    private Random _rand = new Random();
    private int _playerDoorChoice;
    
    public int SwitchDoor(List<int> doors)
    {
        return _playerDoorChoice;
    }

    public int ChooseDoor(List<int> doors)
    {
        _playerDoorChoice = _rand.Next(doors.Count);
        return _playerDoorChoice;
    }
}