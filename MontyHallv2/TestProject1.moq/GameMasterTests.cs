using MontyHallv2.Contestant;
using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;
using Moq;

namespace TestProject1.moq;

public class GameMasterTests
{
    [Fact]
    public void GivenCreateDoorsAndInjectCarToRandomDoorIsCalled_WhenThreeDoorsAreCreatedThenADoorShouldContainACar()
    {
        //Arrange
        var doors = GameMaster.CreateDoorsAndInjectCarToRandomDoor();
        //Act
        var result = doors.Any(door => door.HasCar());
        
        //Assert
        Assert.True(result);
    }
}