using System;

namespace FloatingPointDataTypes
{
    /// <summary>
    /// Floating Point Data Types lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demostrates floating point data types
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int score = 1360;
            int totalSecondsPlayed = 10000;


            // calculate and print points per seconds
            float pointsPerSecond=(float)score/totalSecondsPlayed;
            Console.WriteLine("Point per second: " + pointsPerSecond);
        }
    }
}
