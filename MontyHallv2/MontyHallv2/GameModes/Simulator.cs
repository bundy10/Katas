using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallV2.GameModes;

public class Simulator
{
    private List<Door> _doors;
    private IPlayer _player;
    private const int StartIndex = 1;

    public Simulator(IPlayer player)
    {
        
        _doors = Enumerable.Range(StartIndex, Door.GetCount())
            .Select(_ => new Door())
            .ToList();
        
        _player = player;
    }
    
}