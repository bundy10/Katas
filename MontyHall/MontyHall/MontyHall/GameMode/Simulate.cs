using System.IO.MemoryMappedFiles;
using MontyHall.DoorCreation;
using MontyHall.HostOperations;
using MontyHall.Interfaces;

namespace MontyHall.GameMode;

public class Simulate : ISimulator
{
    public List<int> Doors { get; set; }

    public void Simulator(int numOfDoors, IPlayer player, HostSelection host, PriseInjector priseDoor)
    {
        var door = new Door();
        for (var i = 0; i < numOfDoors; i++)
        {
            door.Doors.Add(0);
        }

        Doors = door.Doors;
    }
}