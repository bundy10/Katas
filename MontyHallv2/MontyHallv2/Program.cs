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
            var game = new Simulator();
            game.Simulate(new StayPlayer());
        }
    }
}