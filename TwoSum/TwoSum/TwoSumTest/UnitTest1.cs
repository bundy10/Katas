using TwoSum;

namespace TwoSumTest;

public class UnitTest1
{
    [Fact]
    public void GivenAnArrayOfInts_WhenTwoSumIsCalled_ThenReturnArrayOfInt()
    {
        //arange
        int[] input = {2,7,11,15};
        const int inputTwo = 9;
        int[] result = { 0, 1 };

        //act
        var actualResult = Sum.TwoSum(input, inputTwo);
        
        //assert
        Assert.Equal(result, actualResult);
    }
    
    [Fact]
    public void GivenAnArrayOfInts_WhenTwoSumHashIsCalled_ThenReturnArrayOfInt()
    {
        //arange
        int[] input = {2,7,11,15};
        const int inputTwo = 9;
        int[] result = { 0, 1 };

        //act
        var actualResult = Sum.TwoSumHash(input, inputTwo);
        
        //assert
        Assert.Equal(result, actualResult);
    }
    
    [Fact]
    public void GivenAnArrayOfInts_WhenTwoSumHashOnePassIsCalled_ThenReturnArrayOfInt()
    {
        //arange
        int[] input = {13,12,10,50,49,312,43,22,99,19,13,11,15,2,7};
        const int inputTwo = 60;
        int[] result = { 2, 3 };

        //act
        var actualResult = Sum.TwoSumHashOnePass(input, inputTwo);
        
        //assert
        Assert.Equal(result, actualResult);
    }
    
    
    [Fact]
    public void GivenAnArrayOfInasdts_WhenTwoSumHashOnePassIsCalled_ThenReturnArrayOfInt()
    {
        //arange
        string[] a1 = new string[] { "arp", "live", "strong" };
        string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
        string[] r = new string[] { "arp", "live", "strong" };

        //act
        var actualResult = Sum.inArray(a1, a2);
        
        //assert
        Assert.Equal(r, actualResult);
    }
}