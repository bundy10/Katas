namespace MontyHall.Interfaces;

public interface IStrategy
{
    DoorSelection Playgame(IEnumerable<DoorSelection> doorSelection);
}