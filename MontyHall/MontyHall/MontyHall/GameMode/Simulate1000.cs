using System.Xml;
using MontyHall.HostOperations;
using MontyHall.Interfaces;

namespace MontyHall.GameMode;

public class Simulate1000 : Simulate
{
    private int _gamesWon;
    private int _gamesLosses;
    public void Simulate1000Times(int numOfDoors, IPlayer player, IGameAdmin host, IGameAdmin prizeDoor)
    {
        var i = 0;
        while (i < 1000)
        {
            var game =  Simulator(numOfDoors, player, host, prizeDoor);
            Console.WriteLine(game);
            _gamesLosses ++;
            _gamesWon++;
            i++;
        }

        var gameLossPercentage = _gamesLosses / 1000;
        var gameWonPercentage = _gamesWon / 1000;
        Console.WriteLine( $"games won {gameWonPercentage} games losses {gameLossPercentage}");
        
    }
}