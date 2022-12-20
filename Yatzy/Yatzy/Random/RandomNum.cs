namespace Yatzy.Random;

public class RandomNum : IRandom
{
    private readonly System.Random _randomNum = new();
    
    public int GetDiceRollNum() => _randomNum.Next(1, 6);

    public List<int> GetFiveDiceRolls() => new List<int>()
    {
        _randomNum.Next(1, 6),
        _randomNum.Next(1, 6),
        _randomNum.Next(1, 6),
        _randomNum.Next(1, 6),
        _randomNum.Next(1, 6),
    };
}