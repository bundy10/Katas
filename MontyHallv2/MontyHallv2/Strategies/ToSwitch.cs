using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.Strategies;

public class ToSwitch : IStrategy
{
    public void ToSwitchOrStay(List<Door> doors)
    {
        doors.RemoveAll(door => door.HasPlayerPicked());
        doors.First(door => door.IsDoorOpened() == false).PlayerPickedDoor();
    }
}