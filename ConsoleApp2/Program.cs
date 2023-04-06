using System;

namespace HorseGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the horse racing game!");
            Console.WriteLine("There are four horses in this race. Please choose the horse you want to bet on:");
            Console.WriteLine("1 - Black Beauty");
            Console.WriteLine("2 - Thunder");
            Console.WriteLine("3 - Lightning");
            Console.WriteLine("4 - Flash");

            int horse = int.Parse(Console.ReadLine());

            Console.WriteLine("How much would you like to bet on your horse?");
            int bet = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int winner = rand.Next(1, 5);

            Console.WriteLine("And they're off!");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(500);
            }

            Console.WriteLine($"The winner is Horse {winner}!");

            if (horse == winner)
            {
                Console.WriteLine($"Congratulations! You won {bet * 2}!");
            }
            else
            {
                Console.WriteLine("Sorry, better luck next time.");
            }
        }
    }
}
