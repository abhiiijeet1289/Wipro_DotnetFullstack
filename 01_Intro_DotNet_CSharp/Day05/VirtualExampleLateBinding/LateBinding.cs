// The base class method is marked virtual, which allows overriding.

// The derived classes use override to replace the base method.

// This is runtime polymorphism (late binding).

// The method called depends on the actual object type, even if the reference is base type.



public class Person
{

    public virtual void GetRole()
    {

        Console.WriteLine("Person class");

    }

}

public class Teacher : Person
{

    //Generally it's overriden but you are hiding that method in the inherited class
    public override void GetRole()
    {

        Console.WriteLine("She is a teacher");

    }

}

public class Mother : Person
{

    //Generally it's overriden but you are hiding that method in the inherited class
    public override void GetRole()
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

// both are having the Car() method but without virtual and override keyword it's not overriding -- they just hide 

