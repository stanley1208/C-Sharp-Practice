using System;

namespace Debugging_a_Console_App
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            float angle;

            // prompt for and get angle
            Console.Write("Enter angle in degrees: ");
            angle=float.Parse(Console.ReadLine());

            // convert angle to radians
            angle*=MathF.PI/180;

            // calculate and print cos and sin
            Console.WriteLine(MathF.Cos(angle));
            Console.WriteLine(MathF.Sin(angle));
        }
    }
}
