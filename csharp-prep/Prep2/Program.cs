using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeLetter = "x";
        Console.Write("Please enter the grade percentage that you received: ");
        string input = Console.ReadLine();
        int gradeNumber = int.Parse(input);

        if(gradeNumber >= 90){

            gradeLetter = "A";

        }

        else if(gradeNumber >= 80){

            gradeLetter = "B";

        }

        else if(gradeNumber >= 70){

            gradeLetter = "C";

        }

        else if(gradeNumber >= 60){

            gradeLetter = "D";

        }

        else{

            gradeLetter = "F";

        }

        Console.WriteLine($"Your grade is a(n) {gradeLetter}.");

        if(gradeLetter == "A" || gradeLetter == "B" || gradeLetter == "C"){

            Console.WriteLine("You passed the class!");

        }

        else{

            Console.WriteLine("You did not pass the class but with some effort you can do it next time.");

        }
    }
}