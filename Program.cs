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
            if (UserSays == "N")
            {
                // #Filter
                Console.WriteLine();
                Console.WriteLine("Is your number HIGHER or LOWER? ");
                Console.WriteLine("Type 'H' if HIGHER, 'L' if LOWER.  ");
                var answer = Console.ReadLine();
                //      IF H
                if (answer == "H")
                {
                    var guess = (mid + max) / 2;
                    Console.WriteLine();
                    Console.WriteLine($"Is your number {guess}? ");



                    // the NewMidPoint is now #Guess
                    // GoTO #Guess

                }
                //         else if (UserSays == L)
                //         {
                //             Guess = max;
                //               var NewGuess = (min / 2 );
                //               Console.WriteLine($"Is your number {NewGuess}? ")

            }
            // - Is your number Higher or Lower
            // - Type "H" or "L"
            //  
            //  Else if L
            // #GUESS = HighNum
            // BottomMarker = LowNum
            // MidPoint is now the #Guess
            // GoTO #Guess
            // Else
            // If Y:
            // - Excellent! It's great to be correct!
            // - Wanna play again?
            // If Y
            // GOTO #Request
            // If N
            // - OK thanks for playing, Goodbye!

        }


    }
}

