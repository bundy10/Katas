using MontyHallv2.Contestant;
using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;
using Moq;

namespace TestProject1.moq;

public class GameMasterTests
{
    
    /*[Fact]
    public void */
    [Fact]
    public void GivenCreateDoorsAndInjectCarToRandomDoorIsCalled_WhenThreeDoorsAreCreated_ThenADoorShouldContainACar()
    {
        //Arrange
        var mockRandom = new Mock<IRandom>();
        var gameMaster = new GameMaster(mockRandom.Object);
        mockRandom.Setup(num => num.GetNumberBetweenRange(It.IsAny<int>(), It.IsAny<int>())).Returns(2);
        
        
        //Act
        var doors = gameMaster.CreateDoorsAndInjectCarToRandomDoor();
        

        var result = doors.FindAll(door => door.HasCar());
        var results = result.Count();
        
        
        //Assert
        Assert.Equal(1, results);
    }
}