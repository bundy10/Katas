namespace MontyHall.Interfaces;

public interface IDoor
{
    IEnumerable<DoorSelection> PickDoor(IEnumerable<DoorPicked> doorpicked);
}