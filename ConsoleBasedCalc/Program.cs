using System;

namespace SimpleConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");
                Console.WriteLine("5: Exit");
                Console.Write("Enter choice (1-5): ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    keepRunning = false;
                    continue;
                }

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 - num2;
                        break;
                    case 3:
                        result = num1 * num2;
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid operation.");
                        continue;
                }

                Console.WriteLine($"Result: {result}");
                Console.WriteLine();
            }

            Console.WriteLine("Calculator has exited. Press any key to close.");
            Console.ReadKey();
        }
    }
}


