using MontyHallv2.Contestant;
using MontyHallV2.DoorCreation;
using MontyHallv2.GameShowStaff;
using MontyHallV2.Interfaces;
using Moq;

namespace TestProject1.moq;

public class GameMasterTests
{
    private readonly Mock<IRandom> _mockRandom;
    private readonly GameMaster _gameMaster;
    public GameMasterTests()
    {
        // Arrange
        _mockRandom = new Mock<IRandom>();
        _gameMaster = new GameMaster(_mockRandom.Object);
    }

    [Fact]
    public void GivenCreateDoorsAndInjectCarToRandomDoorIsCalled_ThenThreeDoorsShouldBeCreated()
    {
        //Arrange
        _mockRandom.Setup(num => num.GetNumberBetweenRange(It.IsAny<int>(), It.IsAny<int>())).Returns(1);
        
        
        //Act
        var doors = _gameMaster.CreateDoorsAndInjectCarToRandomDoor();
        
        
        var numberOfDoors = doors.Count;
        
        
        //Assert
        Assert.Equal(3, numberOfDoors);
    } 
    [Fact]
    public void GivenCreateDoorsAndInjectCarToRandomDoorIsCalled_WhenThreeDoorsAreCreated_ThenADoorShouldContainACar()
    {
        //Arrange
        _mockRandom.Setup(num => num.GetNumberBetweenRange(It.IsAny<int>(), It.IsAny<int>())).Returns(2);
        
        
        //Act
        var doors = _gameMaster.CreateDoorsAndInjectCarToRandomDoor();
        

        var result = doors.FindAll(door => door.HasCar());
        var results = result.Count;
        
        
        //Assert
        Assert.Equal(1, results);
    }
}