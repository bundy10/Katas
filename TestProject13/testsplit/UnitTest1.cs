using TestProject13;

namespace testsplit;

public class UnitTest1
{
    [Fact]
    public void GivenAString_WhenCalculateIsCalled_ThenReturnANumber()
    {

        //arrange
        const string input = "abc";
        string[] exresult;
        exresult = new[] { "ab", "c_" };

        //act
        var actualResult = Split.Splitter(input);

        //assert
        Assert.Equal(exresult, actualResult);

    }
}