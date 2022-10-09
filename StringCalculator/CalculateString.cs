using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace StringCalculator
{
    public static class CalculateString
    {
        public static int Calculate(string input)
        {
            if (!input.Any(char.IsDigit)) return 0;
            var numbers = Numbers.GetNumbers(input);
            return SumOfNumbers(numbers);
        }
        
        private static int SumOfNumbers(IEnumerable<int> numbers) => numbers.Where(n => n <= 1000).Sum();
        

        // public static List<int> GetListOfIntsFromString(string input)
        // {
        //     Regex regex = new Regex(@"\d+");
        //     var results = input
        //     .Select(v => regex.Match(v.ToString()))     // do regex on each item
        //     .Where(m => m.Success)                      // select only those results where regex worked
        //     .Select(m => int.Parse(m.Value))            // convert to int
        //     .ToList();                                  // convert the results to a list
        //
        //     return results;
        // }
        //
        //
        //
        // public static int SumListOfInts(List<int> ListOfInts) => ListOfInts.Sum();
    }
}

