namespace StringCalculator;

public class Validation
{
    public static void ValidateNegativeNumbers(IEnumerable<int> NegativeNumbers)
    {
        if (NegativeNumbers.Count() == 1)
        {
            throw new Exception("Negatives not allowed");
        }
        throw new Exception("Negatives not allowed: " + string.Join(", ", NegativeNumbers));
    }
}