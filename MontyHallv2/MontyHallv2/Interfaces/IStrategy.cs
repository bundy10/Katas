using MontyHallV2.DoorCreation;

namespace MontyHallV2.Interfaces;

public interface IStrategy
{
    public void ToSwitchOrStay(List<Door> doors);
}