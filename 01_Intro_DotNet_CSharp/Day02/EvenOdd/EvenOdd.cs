﻿using System;

class EvenOdd
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check:- ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is Even.");

        }
        else
        {
            Console.WriteLine($"{number} is Odd.");
        }
     }

}