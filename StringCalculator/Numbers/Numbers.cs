using StringCalculator.delimiters;
using StringCalculator.Validator;

namespace StringCalculator.Numbers;

public class Numbers
{
    public IEnumerable<int> numbers { get; set; }
    public string Input { get; set; }
    
    public IEnumerable<int> GetNumbers()
    {
        numbers = GetNumbersFromInput();
        var validate = new Validation();
        var negNumbers = numbers.Where(n => n < 0);;
        validate.negativeNumbers = negNumbers;
        if (validate.negativeNumbers.Any())
        {
            validate.ValidateNegativeNumbers();
        }

        return numbers;
    }

    private IEnumerable<int> GetNumbersFromInput()
    {
        var delimiters = new Dilimiter();
        delimiters.input = Input;
        var theDelimiters = delimiters.GetDelimiters();
        return delimiters.input.Split(theDelimiters, StringSplitOptions.None).Select(int.Parse);
    }
}