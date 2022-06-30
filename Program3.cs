using System;

namespace ReadingDocumentation
{
    /// <summary>
    /// Reading Documentation lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates reading documentation
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // calculate and print cosine of 45 degrees
            float cosine = MathF.Cos(45*MathF.PI/180);
            Console.WriteLine("Cosine of 45 degrees: " + cosine);
        }
    }
}
