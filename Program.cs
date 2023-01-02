using System;

namespace project0
{

    class program
    {

        static void Main(string[] args)
        {

            Random random = new Random();
            bool playAgain = true;
            int max = 100;
            int min = 1;
            int guess;
            int guesses;
            string response;
            int number;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = 0;
                number = random.Next(min, max + 1);
                while (guess != number)
                {

                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine("Your number is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Your number is too low!");
                    }

                    guesses++;
                }
                Console.WriteLine("You WIN!");
                Console.WriteLine("Guesses: " + guesses);
                Console.WriteLine("Number was: " + number);

                Console.WriteLine("Would you like to play again: (Y/N): ");
                Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();

            
        }
    }
}