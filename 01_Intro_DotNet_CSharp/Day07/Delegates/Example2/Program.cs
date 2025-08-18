using System;

class ABC
{
    // Delegates
    public delegate int AddDelegate(int a, int b);
    public delegate void PrintDelegate(int result);

    public static void Main(string[] args)
    {
        // Assign methods to delegates
        AddDelegate addDelegate = AddNumbers;
        PrintDelegate print = PrintResult;

        // Call methods via delegate
        int sum = addDelegate(10, 30);
        print(sum);
    }

    static int AddNumbers(int x, int y)
    {
        return x + y;
    }

    static void PrintResult(int result)
    {
        Console.WriteLine(result);
    }
}
