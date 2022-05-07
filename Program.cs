using System;

namespace NumberGuesser
{
    class Program
    {
        static void DisplayGreeting()
        {
            //  #Greeting
            Console.WriteLine("Hello, I'm great at guessing numbers,");
            Console.WriteLine();
            // #request
            Console.WriteLine("Give me a number between 1 - 1024,");
            Console.WriteLine("Don't tell me the number, Let me guess!");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // 
            var min = 1;
            var max = 1024;
            var mid = (min + max) / 2;
            DisplayGreeting();
            // GuessNumber(min, max);



            // #GuessNumber
            Console.WriteLine();
            Console.WriteLine($"Is your number {mid}?");
            Console.WriteLine("Type 'Y' if true, 'N' if false. ");
            var UserSays = Console.ReadLine();

            // If N:
            // while (UserSays != "Y")
            if (UserSays == "N")

            {   // #Filter
                // - Is your number Higher or Lower
                // - Type "H" or "L"
                Console.WriteLine();
                Console.WriteLine("Is your number HIGHER or LOWER? ");
                Console.WriteLine("Type 'H' if HIGHER, 'L' if LOWER.  ");
                var answer = Console.ReadLine();


                switch (answer)
                //      IF H
                {
                    case "H":
                        var hGuess = (mid + max) / 2;
                        Console.WriteLine();
                        Console.WriteLine($"Is your number {hGuess}? ");
                        break;

                    //  if L
                    case "L":

                        var lGuess = (mid + min) / 2;
                        Console.WriteLine();
                        Console.WriteLine($"Is your number {lGuess}? ");
                        break;


                    // #GUESS = HighNum
                    // BottomMarker = LowNum
                    // MidPoint is now the #Guess
                    // GoTO #Guess
                    // Else
                    case "Y":

                        Console.WriteLine();
                        Console.WriteLine("Excellent! It's great to be correct!");
                        Console.WriteLine("Wanna play again?");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("That's not what I asked for, I'm not playing anymore");
                        Console.WriteLine();
                        break;
                }

                // If Y
                // GOTO #Request
                // If N
                // - OK thanks for playing, Goodbye!

            }

        }
    }
}

