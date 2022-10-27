using MontyHall.Interfaces;

namespace MontyHall.Selections;

public class PlayerChoiceRandom : IPlayerChoice
{
    
    public DoorCreation PlayerChoice(List<DoorCreation> doorCreation)
    {
        Random rnd = new Random();
        int num = rnd.Next(3);
        doorCreation[num] = 0;
        return doorCreation;
    }
    
}