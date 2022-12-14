using MontyHallv2.DoorCreation;
using MontyHallv2.GameModes;
using MontyHallv2.GameShowStaff;
using MontyHallv2.Interfaces;
using MontyHallv2.Random;
using MontyHallv2.Strategies;
using Moq;

namespace TestProject1.moq;

public class SimulatorTests
{
    private readonly Mock<IStrategy> _strategy;
    private SimulatorGame _simulatorGame;
    private Mock<IRandom> _randomNum;

    public SimulatorTests()
    {
        _strategy = new Mock<IStrategy>();
        _randomNum = new Mock<IRandom>();
        _simulatorGame = new SimulatorGame(_strategy.Object, _randomNum.Object);
    }

    [Fact]
    public void GivenPlayerSwitchOrStayDoorIsCalled_ThenSimulationPlayerShouldBePromptedToSwitchOrStayAtADoor()
    {
        //Arrange
        _strategy.Setup(simPlayer => simPlayer.ToSwitchOrStay(It.IsAny<List<Door>>())).Verifiable();
        
        //Act
        _simulatorGame.PlayerSwitchOrStayDoor(It.IsAny<List<Door>>());
        
        //Assert
        _strategy.Verify();
    }
    
    [Fact]
    public void
        GivenPlayerSwitchOrStayDoorIsCalled_WhenTwoDoorsAreEitherPickedAlreadyOrOpened_ThenTheLatterDoorWillBePicked()
    {
        var gameMaster = new GameMaster(new RandomNum());
        var doors = gameMaster.GetDoorsIncludingCarDoors();
        doors[0].PlayerPickedDoor();
        doors[1].PlayerPickedDoor();
        
        _strategy.Setup(simPlayer => simPlayer.ToSwitchOrStay(doors))
            .Callback<List<Door>>(door => door[2].PlayerPickedDoor());
        
        _simulatorGame.PlayerSwitchOrStayDoor(doors);
        
        Assert.True(doors[2].HasPlayerPicked());
    }

    [Fact]
    public void GivenPlayerChooseDoorIsCalled_WhenSimulatorPlayerChoosesDoor_ThenADoorWillHaveBeenPicked()
    {
        //Arrange
        var gameMaster = new GameMaster(new RandomNum());
        var doors = gameMaster.GetDoorsIncludingCarDoors();

        //Act
        _simulatorGame.PlayerChooseDoor(doors);
        var result = doors.Any(door => door.HasPlayerPicked());

        //Assert
        Assert.True(result);

    }
    
    [Fact]
    public void GivenToSwitchOrStayIsCalled_WhenPlayerOptsToStay_ThenTheOriginalDoorPickedWillStayPicked()
    {
        //Arrange
        var gameMaster = new GameMaster(new RandomNum());
        var doors = gameMaster.GetDoorsIncludingCarDoors();
        _randomNum.Setup(num => num.GetNumberBetweenRange(It.IsAny<int>(), It.IsAny<int>())).Returns(0);
        _simulatorGame = new SimulatorGame(new ToStay(), _randomNum.Object);
        
        //Act
        _simulatorGame.PlayerChooseDoor(doors);
        _simulatorGame.PlayerSwitchOrStayDoor(doors);
        var isOriginalDoorStillPicked = doors[0].HasPlayerPicked();

        //Assert
        Assert.True(isOriginalDoorStillPicked);

    }
    
    [Fact]
    public void GivenGetGameOutComeIsCalled_WhenPlayerChoosesTheCarDoorAndOptsToStay_ThenPlayerWillWinTheCar()
    {
        //Arrange
        _randomNum.Setup(num => num.GetNumberBetweenRange(It.IsAny<int>(), It.IsAny<int>())).Returns(0);
        var gameMaster = new GameMaster(_randomNum.Object);
        _simulatorGame = new SimulatorGame(new ToStay(), _randomNum.Object);
        var doors = gameMaster.GetDoorsIncludingCarDoors();
        
        //Act
        _simulatorGame.PlayerChooseDoor(doors);
        _simulatorGame.PlayerSwitchOrStayDoor(doors);
        var hasWon = _simulatorGame.GetGameOutCome(doors);

        //Assert
        Assert.True(hasWon);

    }
    
}
