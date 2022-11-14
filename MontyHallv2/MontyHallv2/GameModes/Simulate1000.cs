using MontyHallV2.Interfaces;

namespace MontyHallV2.GameModes;

public class Simulator1000 : Simulator
{
    private int _gamesWon;
    private int _gamesLosses;
    
    public void Simulate1000(IPlayer player)
    {
        for (var i = 0; i < 1000; i++)
        {
            if (base.Simulate(player))
            {
                _gamesWon++;
            }
            else
            {
                _gamesLosses++;
            }
        }
        
        Console.WriteLine($"{10 * (_gamesWon/_gamesLosses)}% percentage of games won");
        Console.WriteLine($"{10 * (_gamesLosses/_gamesWon)}% percentage of games won");
    }
    
}