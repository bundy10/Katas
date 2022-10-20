namespace StringCalculator.Validator;

public class Validation
{
    public IEnumerable<int> negativeNumbers;
    public IEnumerable<int> numbers { get; set; }
    public void ValidateNegativeNumbers()
    { 
        negativeNumbers = numbers.Where(n => n < 0);
        if (negativeNumbers.Any())
        {
            if (negativeNumbers.Count() == 1)
            {
                throw new Exception("Negatives not allowed");
            }
            throw new Exception("Negatives not allowed: " + string.Join(", ", negativeNumbers));
        }
    }

    public int Validate()
    {
        ValidateNegativeNumbers();
        return IgnoreNumbersOver1000Sum();

    }

    public int IgnoreNumbersOver1000Sum() => numbers.Where(n => n <= 1000).Sum(); //refactor result should'nt be done in validator class
}