using System;

namespace NumberGuesser
{
    class Program
    {
        // greeting Method
        static void DisplayGreeting()
        {
            //  #Greeting
            Console.WriteLine();
            Console.WriteLine("Hello, I'm great at guessing numbers,");
            Console.WriteLine();
            // #request
            Console.WriteLine("Think of a number between 1 - 1024,");
            Console.WriteLine("don't tell me the number, let me guess!");
            Console.WriteLine();
        }
        // Guess method (loop)
        static void GuessNumber(int low, int high)
        {
            var mid = (low + high) / 2;
            Console.WriteLine();
            Console.WriteLine($"Is your number {mid}? Type 'Y' for a corrrect guess, 'L' for lower, 'H' for higher.  ");
            var answer = Console.ReadLine();

            if (answer == "Y")
            {
                Console.WriteLine("Wow, It's great to be a clever computer!");
            }
            else if (answer == "H")
            {
                var NewMin = mid;
                // Console.WriteLine("mid " + mid);
                GuessNumber(NewMin, high);
            }
            else if (answer == "L")
            {
                var NewMax = mid;
                // Console.WriteLine("mid " + mid);
                GuessNumber(low, NewMax);
            }
            else
            {
                Console.WriteLine("error checking");
            }
        }
        static string PromptForAnswer(string prompt)
        {
            // Use the argument, get Y/N - H/L
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }

        static void Main(string[] args)
        {
            var min = 1;
            var max = 1024;

            //start
            //greeting
            DisplayGreeting();

            // Guess
            GuessNumber(min, max);



        }

    }
}


