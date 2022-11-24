using MontyHallV2.DoorCreation;

namespace MontyHallV2.Interfaces;

public interface IGameMode
{
    public void PlayerChooseDoor(List<Door> doors);
    public void PlayerSwitchOrStayDoor(List<Door> doors);
}