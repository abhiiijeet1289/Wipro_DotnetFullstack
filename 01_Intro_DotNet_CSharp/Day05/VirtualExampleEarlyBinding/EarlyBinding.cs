// GetRole() in Teacher and Mother looks like it's overriding — but it's actually hiding the base class method.

// This is early binding (compile-time decision).

// You get warnings, not errors.

// The method called depends on the reference type, not the object type.


public class Person
{
    public void GetRole()
    {
        Console.WriteLine("Person class");
    }
}

public class Teacher : Person
{
    public void GetRole() // hides base method
    {
        Console.WriteLine("She is a teacher");
    }
}

public class Mother : Person
{
    public void GetRole() // hides base method
    {
        Console.WriteLine("She is a Mother");
    }
}


public class MainProgram
{

    static void Main()
    {
        //Late Binding - RunTime Polymorphism
        Person p = new Teacher();
        Person p1 = new Mother();

        p.GetRole();
        p1.GetRole();
    }
}
