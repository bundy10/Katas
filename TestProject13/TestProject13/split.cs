namespace TestProject13;

public class Split
{
    public static string[] Splitter(string input)
    {
        if (input.Length % 2 != 0)
        {
            input += "_";
        }
        return Enumerable.Range(0, input.Length / 2).Select(x => input.Substring(x * 2, 2)).ToArray();
    }
        
    Enumerable.Range(0, input.Length / 2).Select(Index => input.Substring(x*2, 2)).ToArray()
    // {
        // if (input.Length % 2 != 0)
        // {
        //     input += "_";
        // }
        //
        // int numElements = input.Length / 2;
        //
        // string[] result = new string[numElements];
        //
        // for (int i = 0; i < numElements; i++)
        // {
        //     result[i] = input.Substring(i * 2, 2);
        // }
        //
        // return result;
    //
    // check if input is odd or even if its odd, add a _ to string
    // store number of elements we need for the list
    // create string array result to take the number of elements
    // loop through 4 times add pairs using substring to the array
    //return array 
    //
    //
    // }
}