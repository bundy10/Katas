using MontyHall.GameMode;
using MontyHall.HostOperations;

namespace MontyHall.Interfaces;

public interface ISimulator
{
    public string Simulator(int numOfDoors, IPlayer player, IGameAdmin host, IGameAdmin prizeDoor);
}