using System.Xml.Linq;
using System.Collections.Generic;
using MontyHall.Interfaces;

namespace MontyHall
{
    public class MontyHall
    {
        public MontyHall(
            List<DoorCreation> doorCreation, // create number of doors
            IPlayerChoice playerChoice, // player choice of door to select
            IStrategy strategy) // to switch door or not to switch
        {
            _doorCreation = doorCreation;
            _playerChoice = playerChoice;
            _strategy = strategy;

            // get the doors
            // apply the game
            // apply the ai strategy
            // simulate 1000 times
        }

        public virtual DoorCreation PlayGame()
        {
            return new DoorCreation(0);
        }
        
        private readonly List<DoorCreation> _doorCreation;
        private readonly IPlayerChoice _playerChoice;
        private readonly IStrategy _strategy;
    }

}