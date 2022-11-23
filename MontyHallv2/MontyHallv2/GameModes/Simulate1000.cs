using MontyHallV2.Interfaces;

namespace MontyHallV2.GameModes;

public class Simulator1000
{
    private int _gamesWon;

    public void Simulate1000(IStrategy strategy, IGameMode gameMode)
    {
        _gamesWon = 0;
        var game = gameMode;
        for (var i = 0; i < 1000; i++)
        {
            if (game.PlayGame(strategy))
            {
                _gamesWon++;
            }

            
        }
        var losses = ((1000 - _gamesWon) / 1000.0) * 100;
        var gamesWon = (_gamesWon / 1000.0) * 100;
        Console.WriteLine($"{gamesWon}% games won and {losses}% games lost");
    }
    
}