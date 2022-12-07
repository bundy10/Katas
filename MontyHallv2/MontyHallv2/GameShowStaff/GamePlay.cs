using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.GameShowStaff;

public class GamePlay
{
    private readonly IGameMode _gameMode;
    private List<Door> _doors = new ();
    private readonly Host _host = new();
    private readonly IRandom _random;

    public GamePlay(IGameMode gameMode, IRandom random)
    {
        _gameMode = gameMode;
        _random = random;
    }

    public bool PlayGame()
    {
        // create doors add prize to a door
        var gameMaster = new GameMaster(_random);
        _doors = gameMaster.CreateDoorsAndInjectCarToRandomDoor();
        // player/simulation choose a door
        _gameMode.PlayerChooseDoor(_doors);
        // host opens a door 
        var host = new Host();
        host.HostOpensADoor(_doors);
        // player/simulation gets option to switch
        _gameMode.PlayerSwitchOrStayDoor(_doors);
        // game ending - player door contains a car or not
        return _doors.First(door => door.HasPlayerPicked()).HasCar();
    }
}