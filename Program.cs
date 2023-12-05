using System;

namespace Switch_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            // Input validation for a valid integer
            Console.Write("Enter a number (1-3): ");
            while (!int.TryParse(Console.ReadLine(), out number) || (number < 1 || number > 3))
            {
                Console.WriteLine("Invalid input. Please enter a valid number between 1 and 3.");
                Console.Write("Enter a number (1-3): ");
            }

            // Switch statement to check the entered number
            switch (number)
            {
                case 1:
                    Console.WriteLine("You entered '1'");
                    break;
                case 2:
                    Console.WriteLine("You entered '2'");
                    break;
                case 3:
                    Console.WriteLine("You entered '3'");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
