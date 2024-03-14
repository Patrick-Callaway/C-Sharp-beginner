internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Basic Calculator App");

        Console.WriteLine("Please enter your first number!");

        var num1 = Console.ReadLine();

        Console.WriteLine("Please enter your second number!");
        var num2 = Console.ReadLine();
        Console.WriteLine("Please select and operation: Addition, Subtraction, divison, multiplication.");
        var oper = Console.ReadLine();
    }
}