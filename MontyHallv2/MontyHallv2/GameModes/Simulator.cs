using MontyHallV2.DoorCreation;
using MontyHallv2.HostOperations;
using MontyHallV2.Interfaces;

namespace MontyHallV2.GameModes;

public class Simulator
{
    private List<Door> _doors;
    private IPlayer _player;
    private const int StartIndex = 1;
    private int _prizeDoor;
    private int _playerChoice;
    private int _hostDoor;
    private readonly Host _theHost = new Host();
    
    


    public void Simulate(IPlayer player)
    {
        
        _doors = Enumerable.Range(StartIndex, Door.GetCount())
            .Select(_ => new Door())
            .ToList();

        _prizeDoor = _theHost.InjectPrizeToDoor(_doors);
        _doors[_prizeDoor].InjectCarToDoor(); // inject the prize to a door
        _player = player;
        GetPlayerDoorChoice();
        _doors[_playerChoice].PlayerPickedDoor(); // player picking door 
        _hostDoor = _theHost.HostOpensADoor(_prizeDoor, _playerChoice); //host opens a non prize door and player door
        _doors[_hostDoor].OpeningDoor();
        
        
        GameEnding();

    }

    private void GameEnding()
    {
        Console.WriteLine(_doors[_playerChoice].WinOrLoss());
    }

    private void GetPlayerDoorChoice()
    {
        _player.ChooseDoor(_doors);
        _playerChoice = _player.GetChoice();
    }

}