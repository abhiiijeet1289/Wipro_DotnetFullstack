using System;

class Program
{
    static void Main()
    {
        
        string[,] students = new string[5, 2];

        Console.WriteLine("Enter name and age for 5 students:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter name of student #{i + 1}: ");
            students[i, 0] = Console.ReadLine(); // Store name in column 0

            Console.Write($"Enter age of student #{i + 1}: ");
            students[i, 1] = Console.ReadLine(); 
        }

       
        Console.WriteLine("\n--- Student Details ---");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Student #{i + 1} - Name: {students[i, 0]}, Age: {students[i, 1]}");
        }
    }
}
