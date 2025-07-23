// -----------------------------
// MULTILEVEL INHERITANCE EXAMPLE
// -----------------------------
// In Multilevel Inheritance, a child class inherits from a parent class,
// and then another class inherits from that child class.
// So the last class inherits from both its parent and grandparent.
//
// Here, Student inherits from Person, which in turn inherits from Father.

public class Father
{
    public void FatherDetails()
    {
        Console.WriteLine("Father Details:");
    }
}

public class Person : Father
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
        stud.FatherDetails(); // From grandparent class Father
        stud.Display();       // From parent class Person
        stud.Study();         // From Student
    }
}
