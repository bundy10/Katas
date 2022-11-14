using CoffeeMachine.Interfaces;

namespace CoffeeMachine.Parent;

public class Drink 
{
    private int _sugar;
    private bool _stick;


    protected Drink(int sugar)
    {
        _sugar = sugar;
        if (sugar >= 1) _stick = true;
    }
}