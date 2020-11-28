using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user to guess heads or tails, recieve user input
            Console.Write("Guess which will have more: heads or tails? ");
            string headsOrTailsGuess = Console.ReadLine();

            // conversion: heads = 0, tails = 1
            int convertGuess = -1;
            if (headsOrTailsGuess.Equals("heads"))
            {
                convertGuess = 0;
            }
            if (headsOrTailsGuess.Equals("tails"))
            {
                convertGuess = 1;
            }

            // error if user did not type heads or tails
            if (!headsOrTailsGuess.Equals("heads") && (!headsOrTailsGuess.Equals("tails"))){
                Console.WriteLine("Error. Please Provide Correct Input.");
                Environment.Exit(2);
            }

            // Ask user for how many times coin will flip, recieve user input, parse string to int
            Console.Write("How many times shall we flip a coin? ");
            int numberOfFlips = int.Parse(Console.ReadLine());
            Console.Write("\n\n");

            // Flip coin, heads or tails randomly generated through Random class, +1 for every correct guess
            int correctCount = 0;
            Random rnd = new Random();
            for (int i = 0; i < numberOfFlips; i++)
            {
                int flip = rnd.Next(2);
                if (flip == 0)
                {
                    Console.WriteLine("heads");
                }
                if (flip == 1)
                {
                    Console.WriteLine("tails");
                }
                if (flip == convertGuess)
                {
                    correctCount += 1;
                }
            }

            // Percentage of correct guesses
            int percentage = (int)((double)correctCount / numberOfFlips * 100);

            // Results
            Console.WriteLine("\n\nYour guess, " + headsOrTailsGuess + ", came up " + correctCount + " time(s).");
            Console.WriteLine("That's " + percentage + "%");
        }
    }
}
