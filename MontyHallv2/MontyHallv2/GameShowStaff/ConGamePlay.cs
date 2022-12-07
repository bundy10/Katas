using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.GameShowStaff;

        public class ConGamePlay : IGamePlay
        {
            private readonly IGameMode _gameMode;
            private List<Door> _doors = new ();
            private readonly Host _host;
            private readonly GameMaster _gameMaster;

            public ConGamePlay(IGameMode gameMode, IRandom random)
            {
                _gameMode = gameMode;
                _host = new Host();
                _gameMaster = new GameMaster(random);
            }

            public bool PlayGame()
            {   
                _host.WelcomeMessage();
                // create doors add prize to a door
                _doors = _gameMaster.CreateDoorsAndInjectCarToRandomDoor();
                // player/simulation choose a door
                _host.PromptPlayerToPickADoorMessage();
                _gameMode.PlayerChooseDoor(_doors);
                // host opens a door
                _host.HostOpensADoorMessage();
                _host.HostOpensADoor(_doors);
                // player/simulation gets option to switch
                _host.PromptPlayerToStayOrSwitchDoor();
                _gameMode.PlayerSwitchOrStayDoor(_doors);
                // game ending - player door contains a car or not
                return _host.HostGameOutcome(_doors);
            }
        }