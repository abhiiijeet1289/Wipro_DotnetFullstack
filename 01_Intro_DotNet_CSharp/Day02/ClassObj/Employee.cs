using System;

public class Employee
{
    public void Input()
    {
        Console.WriteLine("Enter the first number:- ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sun of a and b is: " + (a + b));
    }

    public void Display()
    {
        Console.WriteLine("Employee class method called!!!");
    }
}