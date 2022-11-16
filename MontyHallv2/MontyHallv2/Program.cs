using System.ComponentModel.DataAnnotations;
using MontyHallV2.DoorCreation;
using MontyHallV2.GameModes;
using MontyHallV2.Interfaces;
using MontyHallv2.Strategies;

namespace MontyHallv2
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            //var game = new Simulator1000();
            //game.Simulate1000(new StayPlayer());
           //game.Simulate1000(new SwitchPlayer());
           
           var doors = Enumerable.Range(1, Door.GetCount())
               .Select(_ => new Door())
               .ToList();

           doors[1].InjectCarToDoor();
           doors[2].InjectCarToDoor();

           doors.First(door => door.HasCarOrPlayerPicked() != true).OpeningDoor();

           var update = doors.Where(door => door.IsDoorOpened()).ToList();
           foreach (var door in update)
           {
               Console.WriteLine(door);
           }
        }
    }
}
    