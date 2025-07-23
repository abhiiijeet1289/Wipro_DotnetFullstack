// -------------------------------
// HIERARCHICAL INHERITANCE EXAMPLE
// -------------------------------
// In Hierarchical Inheritance, multiple child classes inherit from the same parent class.
// Each child gets access to the common properties and methods of the parent.
//
// Here, both Student and Teacher inherit from Person.

public class Person
{
    protected string Name { get; set; }

    public virtual void Display()
    {
        Console.WriteLine("Displaying Name you entered: " + Name);
    }
}

public class Student : Person
{
    public int RollNumber { get; set; }

    public void Study()
    {
        Console.WriteLine(Name + " is studying.");
    }
}

public class Teacher : Person
{
    public string Subject { get; set; }

    public void Teaches()
    {
        Console.WriteLine(Name + " teaches Computer Science.");
    }

    static void Main()
    {
        Teacher t = new Teacher();
        t.Name = "Niti";         // Protected member accessed in derived class
        t.Teaches();             // From Teacher class
        t.Display();             // Inherited from Person class
    }
}
