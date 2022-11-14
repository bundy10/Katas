using System.IO.MemoryMappedFiles;
using MontyHall.DoorCreation;
using MontyHall.HostOperations;
using MontyHall.Interfaces;
using MontyHall.Strategies;

namespace MontyHall.GameMode;

public class Simulate : ISimulator
{
    public List<int>? Doors { get; set; }

    //private object stayPlayer = new StayPlayer();

    //private object switchPlayer = new SwitchPlayer();

    //public object hostSelection = new HostSelection();

    public string Simulator(int numOfDoors, IPlayer player, IGameAdmin host, IGameAdmin prizeDoor)
    {
        var door = new Door();
        for (var i = 0; i < numOfDoors; i++)
        {
            door.doors.Add(0);
        }

        Doors = door.doors;

        var prizeInject = prizeDoor.InjectToRandomDoor(Doors);
        var playerChoice = player.ChooseDoor(Doors);
        var hostSelection = host.InjectToRandomDoor(Doors);

        Doors[prizeInject] = 2;
        while (hostSelection == playerChoice || hostSelection == prizeInject) hostSelection = host.InjectToRandomDoor(Doors);
        Doors[hostSelection] = 1;



        if (Doors[playerChoice] == 2) 
	    {
            return "You win the car";
	    }

        return "You did not win the car";
    }


    //public void getStayPlayer() 
    //{
    //    stayPlayer = new SwitchPlayer();
    //}
    
    //public void getSwitchPlayer() 
    //{
    //    switchPlayer = new SwitchPlayer();
    //}


}   

