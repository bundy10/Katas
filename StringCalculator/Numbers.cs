namespace StringCalculator;

public class Numbers
{
    public static IEnumerable<int> GetNumbers(string input)
    {
        var numbers = GetNumbersFromInput(input);
        var negativeNumbers = numbers.Where(n => n < 0);
        if (negativeNumbers.Any())
        {
            Validation.ValidateNegativeNumbers(negativeNumbers);
        }

        return numbers;
    }

    private static IEnumerable<int> GetNumbersFromInput(string input)
    {
        var delimiters = Delimiter.GetDelimiters(ref input);
        var numbers = input.Split(delimiters, StringSplitOptions.None).Select(int.Parse);
        return numbers;
    }
}