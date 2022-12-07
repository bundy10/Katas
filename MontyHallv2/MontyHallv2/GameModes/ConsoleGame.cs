
using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;
using MontyHallv2.Strategies;

namespace MontyHallV2.GameModes;

public class ConsoleGame : IGameMode
{
    private int _choice;

    public void PlayerChooseDoor(List<Door> doors)
    {
        var value = Console.ReadLine();
        if (value != null) _choice = int.Parse(value) - 1;
        doors[_choice].PlayerPickedDoor();
    }

    public void PlayerSwitchOrStayDoor(List<Door> doors)
    {
        var strategy = new ToSwitch();
        var value = Console.ReadLine();
        if (value == "y")
        {
            strategy.ToSwitchOrStay(doors);
        }
    }
}