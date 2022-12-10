using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.GameShowStaff;

public class GamePlay
{
    private readonly IGameMode _gameMode;
    private List<Door> _doors = new ();
    private readonly Host _host;
    private readonly GameMaster _gameMaster;

    public GamePlay(IGameMode gameMode, IRandom random)
    {
        _gameMode = gameMode;
        _host = new Host();
        _gameMaster = new GameMaster(random);
    }

    public bool PlayGame()
    {
        _doors = _gameMaster.CreateDoorsAndInjectCarToRandomDoor();
        _gameMode.PlayerChooseDoor(_doors);
        _host.HostOpensADoor(_doors);
        _gameMode.PlayerSwitchOrStayDoor(_doors);
        return _gameMode.GameOutComeWinOrLose(_doors);
    }
}