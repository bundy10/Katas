using MontyHallV2.DoorCreation;

namespace MontyHallV2.Interfaces;

public interface IPlayer
{
    public int GetChoice();
    public void ChooseDoor(List<Door> doors);
    public void SwitchDoor(List<Door> doors);
}