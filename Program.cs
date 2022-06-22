using System;

namespace IntegerDataTypes
{
    /// <summary>
    /// Integer Data Types lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates integer data types
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            int totalSecondsPlayed = 100;
            const int SecondsPerMinutes = 60;
            // Exercixe3
            int age = 21;


            // calculate minutes and seconds played
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinutes;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinutes;

            // print minutes and seconds played
            Console.WriteLine("Minutes Played: " + minutesPlayed);
            Console.WriteLine("Seconds Played: " + secondsPlayed);

            // Exercixe3
            Console.WriteLine("My age is " + age);

            // Exercixe4
            Console.Write("Enter first altitude: ");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.Write("Enter second altitude: ");
            int secondAltitude = int.Parse(Console.ReadLine());
            int changealtitude = secondAltitude - firstAltitude;
            Console.WriteLine("The change of altitude is " + changealtitude);


        }
    }
}
