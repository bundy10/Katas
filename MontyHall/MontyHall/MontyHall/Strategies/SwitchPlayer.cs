using MontyHall.DoorCreation;
using MontyHall.Interfaces;
namespace MontyHall.Strategies;

public class SwitchPlayer : IPlayer
{
    private Random _rand = new Random();
    private int _playerDoorChoice;

    public int SwitchDoor(List<int> doors)
    {
        _playerDoorChoice = _rand.Next(doors.Count);
        return _playerDoorChoice;
    }

    public int ChooseDoor(List<int> doors)
    {
        _playerDoorChoice = _rand.Next(doors.Count);
        return _playerDoorChoice;
    }
}