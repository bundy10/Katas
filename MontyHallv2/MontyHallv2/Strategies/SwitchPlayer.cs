using MontyHallV2.DoorCreation;

namespace MontyHallv2.Strategies;

public class SwitchPlayer
{
    private readonly Random _random = new Random();
    private int _choice;

    public int GetChoice()
    {
        return _choice;
    }

    public void ChooseDoor(List<Door> doors)
    {
        _choice = _random.Next(doors.Count);
    }

    public void SwitchDoor(int playerChoice, int hostDoor)
    {
        var doorsAvailable = Enumerable.Range(0, 3).Where(a => a != hostDoor && a != playerChoice).ToArray();
        _choice =  doorsAvailable[0];
    }
}