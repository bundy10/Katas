namespace MontyHallv2.DoorCreation;

public class Door
{
    public bool Opened = false;
    private bool _hasCar = false;

    public void InjectCarToDoor()
    {
        _hasCar = true;
    }

    public string WinOrLoss()
    {
        return _hasCar ? "Congratulations you have won the car!!!" : "Sorry you have not won the car";
    }
}