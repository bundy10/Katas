using MontyHallV2.DoorCreation;

namespace MontyHallV2.Interfaces;

public interface IPlayer
{
    public List<Door> ChooseDoor(List<Door> doors);
    public List<Door> SwitchDoor(List<Door> doors);
    public bool IsPlayerGoingToSwitch();
}