using System;

public interface ICurricularActivities
{
    void Stream();
}

public interface INonCurricularActivities
{
    void Activities();
}

public class Person
{
    public string Name { get; set; }

    public void Display()
    {
        Console.WriteLine($"Student Name: {Name}");
    }
}

public class Student : Person, ICurricularActivities, INonCurricularActivities
{
    public int RollNumber { get; set; }

    public void Study()
    {
        Console.WriteLine("Student is studying...");
    }

    public void Stream()
    {
        Console.WriteLine("Taken Science Stream");
    }

    public void Activities()
    {
        Console.WriteLine("Sports - BasketBall");
    }

    static void Main()
    {
        Student s = new Student();

        Console.WriteLine("Enter the name of student");
        string sname = Console.ReadLine();
        s.Name = sname;

        s.Study();       // own method
        s.Display();     // from Person
        s.Stream();      // from ICurricularActivities
        s.Activities();  // from INonCurricularActivities
    }
}
