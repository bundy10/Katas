using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.GameShowStaff;

public class GamePlay
{
    private readonly IGameMode _gameMode;
    private List<Door> _doors = new ();

    public GamePlay(IGameMode gameMode)
    {
        _gameMode = gameMode;
    }

    public bool PlayGame()
    {
        // create doors add prize to a door
        _doors = GameMaster.CreateDoorsAndInjectCarToRandomDoor();
        // player/simulation choose a door
        _gameMode.PlayerChooseDoor(_doors);
        // host opens a door 
        Host.HostOpensADoor(_doors);
        // player/simulation gets option to switch
        _gameMode.PlayerSwitchOrStayDoor(_doors);
        // game ending - player door contains a car or not
        return _doors.First(door => door.HasPlayerPicked()).HasWonTheCarOrNot();
    }
}