using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResults(name, squaredNumber);

    }

    static void DisplayWelcome()
    {

        Console.WriteLine("Welcome to the program!");

    }

    static string PromptUserName()
    {

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;

    }

    static int PromptUserNumber()
    {

        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int favoriteNumber = int.Parse(input);
        return favoriteNumber;

    }

    static int SquareNumber(int favoriteNumber)
    {

        int squaredNumber = favoriteNumber * favoriteNumber;
        return squaredNumber;

    }

    static void DisplayResults(string name, int squaredNumber)
    {

        Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}.");

    }
}