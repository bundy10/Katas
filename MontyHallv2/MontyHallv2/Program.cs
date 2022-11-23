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
            var game = new Simulator1000();
            var consoleGame = new ConsoleGame();
            game.Simulate1000(new ToStay(), new Simulator());
            game.Simulate1000(new ToSwitch(), new Simulator());
            consoleGame.PlayGame(new ToSwitch());

        }
    }
}
    