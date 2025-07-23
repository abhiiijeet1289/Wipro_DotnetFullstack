// ---------------------------
// SINGLE INHERITANCE EXAMPLE
// ---------------------------
// In Single Inheritance, one child class inherits the members (fields, methods)
// of one parent/base class. This allows code reusability and logical hierarchy.
//
// Here, 'Student' inherits from 'Person' and uses its Display() and Name property.

public class Person
{
    protected string Name { get; set; }

    public virtual void Display()
    {
        Console.WriteLine("Displaying Name you entered: " + Name);
    }

    public void setName(string name)
    {
        this.Name = name;
    }
}

public class Student : Person
{
    public int RollNumber { get; set; }

    public void Study()
    {
        Console.WriteLine(Name + " is studying.");
    }

    static void Main()
    {
        Student stud = new Student();
        stud.setName("Niti");
        stud.RollNumber = 2004;
        stud.Display();   // From base class Person
        stud.Study();     // From derived class Student
    }
}
