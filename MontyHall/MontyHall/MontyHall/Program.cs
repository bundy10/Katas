// See https://aka.ms/new-console-template for more information

using MontyHall.GameMode;
using MontyHall.HostOperations;
using MontyHall.Strategies;

namespace MontyHall
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var winOrLose = new Simulate();
            Console.WriteLine(winOrLose.Simulator(3, new StayPlayer(), new HostSelection(), new PrizeInjector()));
            var thousandWinOrLose = new Simulate1000();
            thousandWinOrLose.Simulate1000Times(3, new StayPlayer(), new HostSelection(), new PrizeInjector());
        }
    }
}




var exclude = new HashSet<int>() { 1 };
var range = Enumerable.Range(0, 3).Where(i => !exclude.Contains(i));

var list = Enumerable.Range(0, 3).Where(a => a != 1).ToArray();

foreach (var word in list)
{
    Console.WriteLine(word);
}
