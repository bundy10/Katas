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
        _doors = Enumerable.Range(1, 3)
            .Select(_ => new Door())
            .ToList();
        //Act
        _host.HostOpensADoor(_doors);
        var getResult = _doors.First(door => door.IsDoorOpened());
        
        //Assert
        Assert.True(getResult.IsDoorOpened());
    }
}