using MontyHallV2.DoorCreation;

namespace MontyHallV2.Interfaces;

public interface IPlayer
{
    public int GetChoice();
    public List<Door> ChooseDoor(List<Door> doors);
    public void SwitchDoor(List<Door> doors, int playerChoice, int hostDoor);
}