namespace Develop02
{
    public class Prompts
    {
        public string _prompt;
        public string _entry;
        public string _dateString;

        public void menu()
        {
            Console.WriteLine("Please pick an option by entering the number of the option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            string input = Console.ReadLine();
            int option = int.Parse(input);

            if(option == 1)
            {
                
            }
            else if(option == 2)
            {}
            else if(option == 3)
            {}
            else if(option == 4)
            {}
            else if(option == 5)
            {}
        }
    }
}