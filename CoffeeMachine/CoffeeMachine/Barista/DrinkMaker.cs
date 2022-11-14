using CoffeeMachine.Interfaces;

namespace CoffeeMachine.Barista;

public class DrinkMaker : IDrinkMaker
{
    private string _drink;
    public void SendCommand(string command)
    {
        _drink = command;
    }

    public string GetDrink()
    {
        return _drink;
    }
}