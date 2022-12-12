using MontyHallV2.DoorCreation;
using MontyHallV2.Interfaces;

namespace MontyHallv2.GameShowStaff;

public class Host
{
    public void HostOpensDoor(List<Door> doors)
    {
        doors.First(door => door.HasCar() != true && door.HasPlayerPicked() != true).OpeningDoor();
    }
}