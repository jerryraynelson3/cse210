using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random random = new Random();
        int magicNumber = random.Next(100);

        int guess = -20;

        while(guess != magicNumber)
        {

            Console.Write("Please guess the magic number: ");
            string input = Console.ReadLine();

            guess = int.Parse(input);

            if(guess < magicNumber)
            {

                Console.WriteLine("The magic number is higher, please try again.");

            }

            else if(guess > magicNumber)
            {

                Console.WriteLine("The magic number is lower, please try again.");

            }

        }

        Console.WriteLine($"You guessed the magic number! It was {magicNumber}.");

    }
}