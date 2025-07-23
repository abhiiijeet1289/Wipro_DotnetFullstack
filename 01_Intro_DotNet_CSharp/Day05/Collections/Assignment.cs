using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var studentData = new Dictionary<int, Dictionary<string, int>>
        {
            [1] = new Dictionary<string, int> { { "Java", 55 }, { "Python", 91 }, { "C#", 80 } },
            [2] = new Dictionary<string, int> { { "Java", 45 }, { "Python", 90 }, { "C#", 80 } }
        };

        foreach (var student in studentData)
        {
            Console.WriteLine($"Student ID: {student.Key}");

            int total = 0;

            foreach (var subject in student.Value)
            {
                Console.WriteLine($"{subject.Key}: {subject.Value}");
                total += subject.Value;
            }

            double average = (double)total / student.Value.Count;
            Console.WriteLine($"Average Marks: {average:F2}\n");
        }
    }
}
