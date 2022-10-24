using System;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("1 - New Game");
            }
            else if (x == 2)
            {
                Console.WriteLine("2 - Load Game");
            }
            else if (x == 3)
            {
                Console.WriteLine("3 - Options");
            }
            else if (x == 4)
            {
                Console.WriteLine("4 - Quit");
            }
            else
            {
                Console.WriteLine("Error");
            }

            int y = int.Parse(Console.ReadLine());

            switch (y)
            {
                case 1:
                    Console.WriteLine("1 - New Game");
                    break;
                case 2:
                    Console.WriteLine("2 - Load Game");
                    break;
                case 3:
                    Console.WriteLine("3 - Options");
                    break;
                case 4:
                    Console.WriteLine("4 - Quit");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
