namespace StringCalculator.Validator;

public class Validation
{
    public IEnumerable<int> negativeNumbers { get; set; }
    public void ValidateNegativeNumbers()
    {
        if (negativeNumbers.Count() == 1)
        {
            throw new Exception("Negatives not allowed");
        }
        throw new Exception("Negatives not allowed: " + string.Join(", ", negativeNumbers));
    }
}