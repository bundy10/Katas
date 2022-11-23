namespace MontyHallV2.Interfaces;

public interface IGameMode
{
    public bool PlayGame(IStrategy strategy);
}