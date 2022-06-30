using System;

namespace Trigonometry_with_floats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // calculate and print cosine of 45 degrees
            Console.Write("Enter the degree: ");
            int degrees = int.Parse(Console.ReadLine());
            float cosine = MathF.Cos(degrees * MathF.PI / 180);
            float sine = MathF.Sin(degrees * MathF.PI / 180);
            Console.WriteLine("Cosine of " + degrees + " degrees: " + cosine);
            Console.WriteLine("Sine of " + degrees + " degrees: " + sine);
        }
    }
}
