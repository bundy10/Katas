using MontyHallV2.DoorCreation;

namespace MontyHallv2.GameShowStaff;

public class Host
{
    public List<Door> HostOpensADoor(List<Door> doors)
    {
        doors.First(door => door.HasCarOrPlayerPicked() != true).OpeningDoor();
        return doors;
    }
}