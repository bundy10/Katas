namespace MontyHall
{
    public struct DoorCreation
    {
        public DoorCreation(int doors)
        {
            for (var i = 0; i < doors; i++)
            {
                Doors.Add(0);
            }
        }

        public List<int> Doors = new List<int>();
    }
}