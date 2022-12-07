using System.Resources;
using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;
using MontyHallv2.Random;
using Moq;

namespace TestProject1.moq;

public class HostTests
{
    private List<Door> _doors;
    private readonly Host _host;
    private readonly GameMaster _gameMaster;

    public HostTests()
    {
        _doors = new List<Door>();
        _host = new Host();
        _gameMaster = new GameMaster(new RandomNum());
    }
    
    [Fact]
    public void GivenHostOpensADoorIsCalled_ThenHostOpensADoor()
    {
        //Arrange
        _doors = _gameMaster.CreateDoorsAndInjectCarToRandomDoor();

        //Act
        _host.HostOpensADoor(_doors);
        var getResult = _doors.FindAll(door => door.IsDoorOpened());
        var result = getResult.Count;
        
        //Assert
        Assert.Equal(1, result);
    }
}