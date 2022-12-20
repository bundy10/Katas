using Yatzy.Random;

namespace Yatzy;

public class Gameplay
{
    private readonly RandomNum _randomNum = new();
    
    public List<int> Roll()
    {
        return _randomNum.GetFiveDiceRolls();
    }
}