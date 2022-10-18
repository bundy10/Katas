using StringCalculator;

namespace StringCalculatorTest;

public class UnitTest1
{
    //step 1
    [Fact]
    public void GivenAString_WhenCalculateIsCalled_ThenReturnANumber()
    {

        //arrange
        const string input = "string";
        var calc = new CalculateString();

        //act
        var actualResult = calc.Calculate(input);

        //assert
        Assert.IsType<int>(actualResult);

    }

    //step 1.5
    [Fact]
    public void GivenAnEmptyString_WhenCalculateIsCalled_ThenReturnZero()
    {
        //arrange
        const string input = "";
        var calc = new CalculateString();

        //act
        var actualResult = calc.Calculate(input);

        //assert
        Assert.Equal(0, actualResult);
    }

    //step 2
    [Fact]
    public void GivenANumber_WhenCalculateIsCalled_ThenReturnTheSameNumber()
    {

        //arrange
        const int input = 8;
        var calc = new CalculateString();

        //act
        var actualResult = calc.Calculate(input.ToString());

        //assert
        Assert.Equal(input, actualResult);
    }

    //step 3
    [Theory]
    [InlineData(3, "1,2")]
    [InlineData(8, "3,5")]

    public void GivenTwoNumbers_WhenCalculateIsCalled_ThenReturnTheSumOfTheNumbers(int expectedResult, string input)
    {
        var calc = new CalculateString();

        //act
        var actualResult = calc.Calculate(input);

        //assert
        Assert.Equal(expectedResult, actualResult);
    }


    //step 4
    [Theory]
    [InlineData(6, "1,2,3")]
    [InlineData(20, "3,5,3,9")]
    [InlineData(50, "10,20,20")]

    public void GivenAnyAmountOfNumbers_WhenCalculateIsCalled_ThenReturnTheSumOfTheNumbers(int expectedResult, string input)
    {
        var calc = new CalculateString();

        //act
        var actualResult = calc.Calculate(input);

        //assert
        Assert.Equal(expectedResult, actualResult);
    }

    //step 5
    [Theory]
    [InlineData(6, "1,2\n3")]
    [InlineData(20, "3\n5\n3,9")]

    public void GivenAnyAmountOfNumbersWithNewLinesAndCommas_WhenCalculateIsCalled_ThenReturnTheSumOfTheNumbersNewlinesAndCommasShouldBeInterchangeable(int expectedResult, string input)
    {
        var calc = new CalculateString();

        //act
        var actualResult = calc.Calculate(input);

        //assert
        Assert.Equal(expectedResult, actualResult);
    }

    //step 6
    [Fact]
    public void Given_WhenCalculateIsCalled_ThenReturnANumber()
    {

        //arrange
        const string input = "//;\n1;2";
        var calc = new CalculateString();

        //act
        var actualResult = calc.Calculate(input);

        //assert
        Assert.Equal(3, actualResult);

    }

    //step 7
    [Fact]
    public void GivenANegativeNumber_WhenCalculateIsCalled_ThenAnExceptionWillOccur()
    {
        //arrange
        const string input = "-1";
        var calc = new CalculateString();

        //act
        var exception = Assert.Throws<Exception>(() => calc.Calculate(input));

        //assert
        Assert.Equal("Negatives not allowed", exception.Message);
    }

    //step 7.5
    [Fact]
    public void GivenMultipleNegativeNumbers_WhenCalculateIsCalled_ThenAnExceptionWillOccurWithTheNegativeNumbers()
    {
        //arrange
        const string input = "-1,2,-3";
        var calc = new CalculateString();

        //act
        var exception = Assert.Throws<Exception>(() => calc.Calculate(input));

        //assert
        Assert.Equal("Negatives not allowed: -1, -3", exception.Message);
    }

    //step 8
    [Fact]
    public void GivenStringWithNumbersOver1000_WhenCalculateIsCalled_ThenLargeNumbersShouldBeIgnored()
    {
        //arrange
        const string input = "2, 1001";
        var calc = new CalculateString();

        //act
        var actualResult = calc.Calculate(input);

        //assert
        Assert.Equal(2, actualResult);
    }


    //step 9
    [Fact]
    public void GivenStringWithLongDelimiters_WhenCalculateIsCalled_ThenReturnSumOfNumbers()
    {
        //arrange
        const string input = "//[*****]\n1*****2*****3";
        var calc = new CalculateString();

        //act
        var actualResult = calc.Calculate(input);

        //assert
        Assert.Equal(6, actualResult);
    }

    //step 10
    [Fact]
    public void GivenStringWithMultipleDelimiters_WhenCalculateIsCalled_ThenReturnSumOfNumbers()
    {
        //arrange
        const string input = "//[*][%]\n1*2%3";
        var calc = new CalculateString();

        //act
        var actualResult = calc.Calculate(input);

        //assert
        Assert.Equal(6, actualResult);
    }

    //step 11
    [Fact]
    public void GivenStringWithMultipleLongDelimiters_WhenCalculateIsCalled_ThenReturnSumOfNumbers()
    {
        //arrange
        const string input = "//[***][#][%]\n1***2#3%4";
        var calc = new CalculateString();

        //act
        var actualResult = calc.Calculate(input);

        //assert
        Assert.Equal(10, actualResult);
    }

    //step 12
    [Fact]
    public void GivenStringWithMultipleLongDelimitersWithNumbers_WhenCalculateIsCalled_ThenReturnSumOfNumbers()
    {
        //arrange
        const string input = "//[*1*][%]\n1*1*2%3";
        var calc = new CalculateString();

        //act
        var actualResult = calc.Calculate(input);

        //assert
        Assert.Equal(6, actualResult);
    }
}
