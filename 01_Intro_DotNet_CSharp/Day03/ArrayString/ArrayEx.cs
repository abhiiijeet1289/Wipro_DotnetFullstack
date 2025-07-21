// 5 Students Name

using System;

class Program
{
    static void Main()
    {
       
        string[] students = new string[5];

        Console.WriteLine("Enter names of 5 students:");
        for (int i = 0; i < students.Length; i++)
        {
            Console.Write($"Enter name of student #{i + 1}: ");
            students[i] = Console.ReadLine();
        }

        Console.WriteLine("\nList of students:");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"Student #{i + 1}: {students[i]}");
        }
    }
}
