using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;

namespace MontyHallV2.GameModes;

public class Simulator
{
    private List<Door> _doors;
    private IPlayer _player;
    private const int StartIndex = 1;
    private int _prizeDoor;
    private int _hostDoor;
    private readonly Host _theHost = new Host();
    private readonly GameMaster _gameMaster = new GameMaster();


    public bool Simulate(IPlayer player)
    {
        _doors = _gameMaster.CreateDoorsAndInjectCarToRandomDoor();
        _player = player;
        _doors = player.ChooseDoor(_doors);
        _doors = _theHost.HostOpensADoor(_doors); //host opens a non prize door and player door
        return GameEnding(_doors);
    }

    private bool GameEnding(List<Door> doors)
    { 
      return doors.First(door => door.HasPlayerPicked()).HasWonTheCar();
    }
    

    private void GetPlayerSwitchChoiceOfDoor()
    {
        //_player.SwitchDoor(_doors, _playerChoice, _hostDoor);
        //_playerChoice = _player.GetChoice();
    }

}