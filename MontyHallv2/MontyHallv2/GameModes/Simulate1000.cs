using MontyHallV2.Interfaces;

namespace MontyHallV2.GameModes;

public class Simulator1000
{
    private int _gamesWon;

    public void Simulate1000(IPlayer player)
    {
        var game = new Simulator();
        for (var i = 0; i < 1000; i++)
        {
            if (game.Simulate(player))
            {
                _gamesWon++;
            }
        }
    }
    
}