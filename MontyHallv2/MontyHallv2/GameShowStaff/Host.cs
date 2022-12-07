using MontyHallV2.DoorCreation;

namespace MontyHallv2.GameShowStaff;

public class Host
{
    public void HostOpensADoor(List<Door> doors)
    {
        doors.First(door => door.HasCar() != true && door.HasPlayerPicked() != true).OpeningDoor();
    }
}