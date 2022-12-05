using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using Moq;

namespace TestProject1.moq;

public class HostTests
{
    private List<Door> _doors = new();
    private readonly Host _host = new();

    [Fact]
    public void GivenHostOpensADoorIsCalled_ThenHostOpensADoor()
    {
        //Arrange
        _doors = GameMaster.CreateDoorsAndInjectCarToRandomDoor();
        //Act
        _host.HostOpensADoor(_doors);
        var getResult = _doors.FindAll(door => door.IsDoorOpened());
        var result = getResult.Count;
        
        //Assert
        Assert.Equal(1, result);
    }
}