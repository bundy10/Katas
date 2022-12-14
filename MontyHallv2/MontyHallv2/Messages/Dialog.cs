using MontyHallv2.DoorCreation;

namespace MontyHallv2.Messages;

public static class Dialog
{
    public static bool HostGameOutcome(List<Door> doors)
    {
        if (doors.First(door => door.HasPlayerPicked()).HasCar())
        {
            Console.WriteLine(ConstantDialogs.WinningCar);
            return true;
        }
        Console.WriteLine(ConstantDialogs.LosingCar);
        return false;
    }
    public static void InvalidDoorSelectionInputMessage()
    {
        Console.WriteLine(ConstantDialogs.InvalidUserDoorSelectionInput);
    }
    public static void PromptPlayerToPickADoorMessage()
    {
        Console.WriteLine(ConstantDialogs.PlayerSelectADoor);
    }

    public static void PromptPlayerToStayOrSwitchDoor()
    {
        Console.WriteLine(ConstantDialogs.ToSwitchOrstay);
    }

    public static void InvalidSwitchOrStayChoiceInputMessage()
    {
        Console.WriteLine(ConstantDialogs.InvalidUserSwitchOrStay);
    }
}