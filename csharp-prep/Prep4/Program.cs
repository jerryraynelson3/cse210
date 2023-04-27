using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int number = -2;
        int sum = 0;
        
        Console.WriteLine("Please enter a list of numbers one at a time and type 0 when finished.");

        while(number != 0)
        {

            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            numbers.Add(number);

        }

        int numberOfNumbers = numbers.Count - 1;

        for(int i = 0; i < numberOfNumbers; i++)
        {

            sum += numbers[i];

        }

        float average = sum / numberOfNumbers;

        Console.WriteLine($"The sum of all the numbers is {sum}.");
        Console.WriteLine($"The Average of all the numbers is {average}.");

    }
}