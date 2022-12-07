using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.GameShowStaff;

public class Host
{
    public void HostOpensADoor(List<Door> doors)
    {
        doors.First(door => door.HasCar() != true && door.HasPlayerPicked() != true).OpeningDoor();
    }

    public bool HostGameOutcome(List<Door> doors)
    {
        if (doors.First(door => door.HasPlayerPicked()).HasCar())
        {
            Console.WriteLine("Congratulations you have won the car");
            return true;
        }
        Console.WriteLine("Sorry you have not won the car :(");
        return false;
    }
    public void WelcomeMessage()
    {
        Console.WriteLine("welcome to Monty Hall!");
    }
    public void PromptPlayerToPickADoorMessage()
    {
        Console.WriteLine("Please select a Door from 1 to 3");
    }
    public void HostOpensADoorMessage()
    {
        Console.WriteLine("I will now open a Door");
    }
    public void PromptPlayerToStayOrSwitchDoor()
    {
        Console.WriteLine("If you Would like to switch your door please enter y");
    }
}