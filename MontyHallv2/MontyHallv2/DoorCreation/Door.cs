namespace MontyHallV2.DoorCreation;

public class Door
{
    private bool _opened;
    private bool _hasCar;
    private bool _playerPicked;
    private const int Count = 3; // refactor 

    public static int GetCount() => Count; // refactor

    public void OpeningDoor()
    {
        _opened = true;
    }

    public void PlayerPickedDoor()
    {
        _playerPicked = true;
    }

    public void PlayerUnpickDoor()
    {
        _playerPicked = false;
    }
    public void InjectCarToDoor()
    {
        _hasCar = true;
    }

    public bool HasWon()
    {
        return _hasCar && _playerPicked;
    }

    public bool HasCarOrPlayerPicked()
    {
        return _hasCar || _playerPicked;
    }

    public bool IsDoorOpened()
    {
        return _opened;
    }
}