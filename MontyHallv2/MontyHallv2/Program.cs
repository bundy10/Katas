using System.ComponentModel.DataAnnotations;
using MontyHallV2.DoorCreation;
using MontyHallV2.GameModes;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;
using MontyHallv2.Random;
using MontyHallv2.Strategies;

namespace MontyHallv2
{
    internal static class Program
    {
        public static void Main()
        {
            var game = new Simulator1000();
            var consoleGame = new GamePlay(new ConsoleGame(), new RandomNum());
            game.Simulate1000(new SimulatorGame(new ToStay()), new RandomNum());
            game.Simulate1000(new SimulatorGame(new ToSwitch()), new RandomNum());
            consoleGame.PlayGame();
        }
    }
}
    