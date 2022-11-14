namespace MontyHallV2.DoorCreation;

public class Door
{
    private bool _opened;
    private bool _hasCar;
    private bool _playerPicked;
    private const int Count = 3;

    public static int GetCount() => Count;

    public void OpeningDoor()
    {
        _opened = true;
    }

    public void PlayerPickedDoor()
    {
        _playerPicked = true;
    }
    public void InjectCarToDoor()
    {
        _hasCar = true;
    }

    public string WinOrLoss()
    {
        return _hasCar && _playerPicked ? "Congratulations you have won the car!!!" : "Sorry you have not won the car";
    }
}