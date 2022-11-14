namespace MontyHallv2
{
    internal static class Program
    {
        private static readonly Random Random = new Random();
        public static void Main(string[] args)
        {
            Console.WriteLine(Random.Next(3));
        }
    }
}