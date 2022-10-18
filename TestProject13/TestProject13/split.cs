namespace TestProject13;

public class Split
{
    public static string[] Splitter(string input)
    {
        if (input.Length % 2 != 0)
        {
            input += "_";
        }
        return Enumerable.Range(0, input.Length).Select(x => input.Substring(x, 2)).ToArray();
    }
        

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
    //
    //
    // }
}