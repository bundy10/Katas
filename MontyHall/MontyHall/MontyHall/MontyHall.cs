using System.Xml.Linq;
using System.Collections.Generic;
using MontyHall.Interfaces;

namespace MontyHall
{
    public class MontyHall
    {
        public MontyHall(
            IEnumerable<DoorSelection> doorSelection,
            IDoor door,
            IStrategy strategy)
        {
            _doorSelection = doorSelection;
            _door = door;
            _strategy = strategy;

            // get the doors
            // apply the game
            // apply the ai strategy
            // simulate 1000 times
        }

        public virtual DoorSelection PlayGame()
        {
            var doorSelection = _doorSelection;
            doorSelection = _door.PickDoor(doorSelection);
            return _strategy.Playgame(doorSelection);
        }
        private readonly IEnumerable<DoorSelection> _doorSelection;
        private readonly IDoor _door;
        private readonly IStrategy _strategy;
    }

}