using System;

class Program
{
    static void Main()
    {
        int studentCount = 5;

       
        string[] studentNames = new string[studentCount];

        
        string[][] studentSubjects = new string[studentCount][];

        
        for (int i = 0; i < studentCount; i++)
        {
            Console.Write($"\nEnter name of student #{i + 1}: ");
            studentNames[i] = Console.ReadLine();

            Console.Write($"Enter number of subjects taken by {studentNames[i]}: ");
            int subjectCount = int.Parse(Console.ReadLine());

            studentSubjects[i] = new string[subjectCount];

            for (int j = 0; j < subjectCount; j++)
            {
                Console.Write($"Enter name of subject #{j + 1} for {studentNames[i]}: ");
                studentSubjects[i][j] = Console.ReadLine();
            }
        }

        // 4. Display the data
        Console.WriteLine("\n--- Student Subjects Summary ---");

        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"\nStudent: {studentNames[i]}");
            Console.WriteLine("Subjects:");
            for (int j = 0; j < studentSubjects[i].Length; j++)
            {
                Console.WriteLine($"- {studentSubjects[i][j]}");
            }
        }
    }
}
