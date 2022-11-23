using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;
using MontyHallv2.Validation;

namespace MontyHallv2.Contestant;

public class ConsolePlayer
{
    private PlayerChoiceValidator _validator = new PlayerChoiceValidator();
    private int _choice;
    public void ChooseDoor(List<Door> doors)
    {
        var value = Console.ReadLine();
        if (value != null) _choice = int.Parse(value) - 1;
        doors[_choice].PlayerPickedDoor();
    }
}