using System;
using System.Linq;
namespace StringCalculator;

public static class Delimiter
{
    private static string[] delimiters;
    public static string[] GetDelimiters(ref string input)
    {
        if (input.StartsWith("//"))
        {
            return GetMultipleAndCustomDelimiters(ref input);
        }
        return new[] { ",", "\n" }; // if string does not start with // then jkust take , and \n as delimiters this can be improved
    }

    private static string[] GetMultipleAndCustomDelimiters(ref string input)
    {
        if (input[2] == '[')
        {
            var delimiterEndIndex = input.LastIndexOf(']'); //get index of last ending square bracket
            delimiters = input.Substring(3, delimiterEndIndex - 3).Split("]["); //reduce the string starting from first sq bracket and last square bracket
            input = input.Substring(delimiterEndIndex + 2); //reduce string to just the numbers seperated by delimiters
        }
        else
        {
            delimiters = new[] { input[2].ToString() }; //take the delimiter at index 2 after the //
            input = input.Substring(4); //reduce string to just the numbers seperated by delimiters
        }
        return delimiters;
    }
}


