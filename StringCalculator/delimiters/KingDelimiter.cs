namespace StringCalculator.delimiters;

public class KingDelimiter
{
    public const string CustomDilimiterStart = "//";
    public const int IndexOfFirstDilimiter = 3;
    public const char StartOfCustomDelimiter = '[';
    public const char EndOfCustomDelimiter = ']';
    public string[] _defaultDelimiters = {",", "\n"};
    public string[] CustomMultipleDelimiters;
    public string input { get; set; }
    
    
    
    
    public string[] GetDelimiters()
    {
        if (input.StartsWith(CustomDilimiterStart))
        {
            return GetMultipleAndCustomDelimiters();
        }
        return _defaultDelimiters; // if string does not start with // then jkust take , and \n as delimiters this can be improved
    }

    private string[] GetMultipleAndCustomDelimiters()
    {
        if (input[2] == StartOfCustomDelimiter)
        {
            var delimiterEndIndex = LastIndexOfDelimiters(); //get index of last ending square bracket
            CustomMultipleDelimiters = input.Substring(IndexOfFirstDilimiter, delimiterEndIndex - IndexOfFirstDilimiter).Split("]["); //reduce the string starting from first sq bracket and last square bracket
            input = input.Substring(delimiterEndIndex + 2); //reduce string to just the numbers seperated by delimiters
        }
        else
        {
            CustomMultipleDelimiters = new[] { input[2].ToString() }; //take the delimiter at index 2 after the //
            input = input.Substring(4); //reduce string to just the numbers seperated by delimiters
        }
        return CustomMultipleDelimiters;
    }

    private int LastIndexOfDelimiters()
    { 
        return input.LastIndexOf(EndOfCustomDelimiter);
    }
}
