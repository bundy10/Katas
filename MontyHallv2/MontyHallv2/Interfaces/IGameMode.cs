using MontyHallV2.DoorCreation;
using MontyHallv2.Messages;

namespace MontyHallV2.Interfaces;

public interface IGameMode
{
    public void PlayerChooseDoor(List<Door> doors);
    public void PlayerSwitchOrStayDoor(List<Door> doors);
    public bool GameOutComeWinOrLose(List<Door> doors);
}