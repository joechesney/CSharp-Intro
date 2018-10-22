using System;

namespace Treehouse_CSharp
{
    class Program
    {
        static void Main()
        {
            int runningTotal = 0;

            // Prompt user for minutes exercised
            Console.Write("Enter how many minutes you exercised: ");

            string minutesExercised = Console.ReadLine();
            int minutes = int.Parse(minutesExercised);
            runningTotal = runningTotal + minutes;

            // Add minutes exercised to total

            // Display total minutes exercised to the screen
            Console.WriteLine("You've exercised " + runningTotal + " minutes! Great job!");

            // Repeat until user quits
            // Main();
        }
    }
}
