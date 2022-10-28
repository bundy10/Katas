using MontyHall.DoorCreation;

namespace MontyHall.Interfaces;

public interface IPlayer
{
    public int SwitchDoor(List<int> doors);
    public int ChooseDoor(List<int> doors);
}