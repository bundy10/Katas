namespace MontyHallv2.Validation;

public class PlayerChoiceValidator
{
    public bool CheckIfPlayerInputIsAnIntBetweenOneAndThree(string input)
    {
        if (int.TryParse(input, out int result))
        {
            if (result > 3 || result < 0)
            {
                return false;
            }

            return true;
        }

        return false;
    }
}