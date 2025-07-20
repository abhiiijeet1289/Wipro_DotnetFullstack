using System;

public class IfElsee
{
    public static void Main()
    {
        Console.WriteLine("Enter first number:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter operation (+, -, *, /):");
        string op = Console.ReadLine();

        if (op == "+")
            Console.WriteLine("Result: " + (a + b));
        else if (op == "-")
            Console.WriteLine("Result: " + (a - b));
        else if (op == "*")
            Console.WriteLine("Result: " + (a * b));
        else if (op == "/")
        {
            if (b != 0)
                Console.WriteLine("Result: " + (a / b));
            else
                Console.WriteLine("Cannot divide by zero");
        }
        else
            Console.WriteLine("Invalid operator");
    }
}
