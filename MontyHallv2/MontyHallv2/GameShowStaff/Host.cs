using MontyHallV2.DoorCreation;

namespace MontyHallv2.GameShowStaff;

public class Host
{
    public static void HostOpensADoor(List<Door> doors)
    {
        doors.First(door => door.HasCarOrPlayerPicked() != true).OpeningDoor();
    }
}