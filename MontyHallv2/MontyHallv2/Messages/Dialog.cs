using MontyHallv2.DoorCreation;

namespace MontyHallv2.Messages;

public static class Dialog
{
    public static bool HostGameOutcome(List<Door> doors)
    {
        if (doors.First(door => door.HasPlayerPicked()).HasCar())
        {
            Console.WriteLine("Congratulations you have won the car");
            return true;
        }
        Console.WriteLine("Sorry you have not won the car :(");
        return false;
    }
    public static void InvalidDoorSelectionInputMessage()
    {
        Console.WriteLine("Please enter a number from 1 to 3");
    }
    public static void PromptPlayerToPickADoorMessage()
    {
        Console.WriteLine("Please select a Door from 1 to 3");
    }
    /*public void HostOpensADoorMessage()
    {
        Console.WriteLine("I will now open a Door");
    }*/
    public static void PromptPlayerToStayOrSwitchDoor()
    {
        Console.WriteLine("If you Would like to switch your door please enter 'y' or 'n' to stay");
    }

    public static void InvalidSwitchOrStayChoiceInputMessage()
    {
        Console.WriteLine("Please enter y or n");
    }
}