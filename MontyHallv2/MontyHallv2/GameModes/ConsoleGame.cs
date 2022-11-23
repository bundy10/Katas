using MontyHallv2.Contestant;
using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;

namespace MontyHallV2.GameModes;

public class ConsoleGame : IGameMode
{
    private List<Door>? _doors;
    private readonly ConsolePlayer _consolePlayer = new();
    public bool PlayGame(IStrategy strategy)
    {
        _doors = GameMaster.CreateDoorsAndInjectCarToRandomDoor();
        Console.WriteLine("Please choose a door from 1 to 3");
        _consolePlayer.ChooseDoor(_doors);
        Host.HostOpensADoor(_doors);
        Console.WriteLine("would you like to switch door? (y/n)");
        var value = Console.ReadLine();

        if (value == "y")
        {
            strategy.ToSwitchOrStay(_doors);
        }

        if (_doors.First(door => door.HasPlayerPicked()).HasWonTheCarOrNot())
        {
            Console.WriteLine("you have won the car");
        }
        else
        {
            Console.WriteLine("you did not win the car");
        }

        return _doors.First(door => door.HasPlayerPicked()).HasWonTheCarOrNot();
    }
}