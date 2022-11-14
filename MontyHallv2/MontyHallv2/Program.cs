using System.ComponentModel.DataAnnotations;
using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2
{
    internal static class Program
    {
        private static List<Door> _doors;
        private static IPlayer _player;
        private const int StartIndex = 1;
        private static readonly Random Random = new Random();
        public static void Main(string[] args)
        {
            var hey = Random.Next(Door.GetCount());
            Console.WriteLine(hey);
        }
    }
}