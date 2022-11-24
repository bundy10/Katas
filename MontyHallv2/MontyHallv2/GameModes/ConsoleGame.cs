using MontyHallv2.Contestant;
using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;

namespace MontyHallV2.GameModes;

public class ConsoleGame : IGameMode
{
    private readonly ConsolePlayer _consolePlayer = new();

    public void PlayerChooseDoor(List<Door> doors)
    {
        _consolePlayer.ChooseDoor(doors);
    }

    public void PlayerSwitchOrStayDoor(List<Door> doors)
    {
        // _consolePlayer.ChooseSwitchOrStay(strategy, doors);
    }
}