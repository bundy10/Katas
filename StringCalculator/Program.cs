using System;
using Microsoft.VisualBasic;

namespace StringCalculator
{
    public class Program
    {
        public static void Main()
        {
            var input = "1";
            var calc = new CalculateString();
            var actualResult = calc.Calculate(input);
        }
    }
}

