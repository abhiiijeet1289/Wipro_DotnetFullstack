// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;
using static ABC;


//Delegate - It is type safe that hold a reference to a method 
// DelegateName my1 = new DelegateName(Print);

//Admin delegate Is responsible generating a invoice;

//Admin a = new Admin(Invoice);
//A delegate also allows methods to be passed as a parameters and invoked dynamically(at runtime)
//It is used to implement event handling


//Syntax   AccessSpecifier delegate void delegate_name(paramater_list)


using System; // Required for Console.WriteLine

class ABC
{
    public static void Invoice() { Console.WriteLine("Invoice method called"); }

    public delegate void MyShow();
    public delegate void Printing();
    public delegate void Admin();

    static void Main(String[] args)
    {
        MyShow my = new MyShow(Show);
        Printing my1 = new Printing(Print);
        Admin a = new Admin(Invoice);

        // You forgot to invoke them!
        my();   // Output: Show method called using Delegate
        my1();  // Output: Print method called using Delegate
        a();    // Output: Invoice method called
    }

    public static void Show()
    {
        Console.WriteLine("Show method called using Delegate");
    }

    public static void Print()
    {
        Console.WriteLine("Print method called using Delegate");
    }
}
