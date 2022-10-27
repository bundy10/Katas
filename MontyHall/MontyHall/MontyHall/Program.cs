// See https://aka.ms/new-console-template for more information

using MontyHall.Selections;

namespace MontyHall
{
    class Program
    { 
        static void Main(string[] args)
        {
            var monty = new MontyHall(new List<DoorCreation> { _doorCreations }, new PlayerChoiceRandom(), 3);
        }

        private static DoorCreation _doorCreations = new DoorCreation(3);
    }
}