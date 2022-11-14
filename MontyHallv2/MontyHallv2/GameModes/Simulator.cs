using MontyHallV2.DoorCreation;
using MontyHallv2.HostOperations;
using MontyHallV2.Interfaces;

namespace MontyHallV2.GameModes;

public class Simulator
{
    private List<Door> _doors;
    private IPlayer _player;
    private const int StartIndex = 1;
    private int _playerChoice;
    private Host _theHost = new Host();


    public Simulator(IPlayer player)
    {
        
        _doors = Enumerable.Range(StartIndex, Door.GetCount())
            .Select(_ => new Door())
            .ToList();

        _doors[_theHost.InjectPrizeToDoor(_doors)].InjectCarToDoor(); // inject the prize to a door
        _player = player;
        GetPlayerDoorChoice();
        _doors[_playerChoice].PlayerPickedDoor(); // player picking door 
        
    }

    private void GetPlayerDoorChoice()
    {
        _player.ChooseDoor(_doors);
        _playerChoice = _player.GetChoice();
    }

}