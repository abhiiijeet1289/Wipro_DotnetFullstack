using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");

        Console.WriteLine("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Operator :- +, -, *, /: ");
        char op = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter Second Number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num2 / num1;
                else
                    Console.WriteLine("Cannot divide by zero.");
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;



        }
        Console.WriteLine("Result: " + result);


    } 
}
