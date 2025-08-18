// Program.cs
using System;
using System.Linq;
using ConsoleApp2;

public static class NewService
{
    // Extension Method 1: Adds Test4 method to OldService
    public static void Test4(this OldService ser)
    {
        Console.WriteLine("New extension Method: Test4");
    }

    // Extension Method 2: Adds Test5 method with parameters
    public static void Test5(this OldService ser1, int x, int y)
    {
        int result = x + y;
        Console.WriteLine("Sum: " + result);
        Console.WriteLine("Value from OldService: " + ser1.x);
    }

    // Extension Method 3: Adds IsPalindrome to string
    public static bool IsPalindrome(this string s)
    {
        var rev = new string(s.Reverse().ToArray());
        return s.Equals(rev, StringComparison.OrdinalIgnoreCase);
    }
}

class Program
{
    public static void Main()
    {
        OldService sobj = new OldService();

        sobj.Test1();
        sobj.Test2();

        // Calling extension methods
        sobj.Test4();
        sobj.Test5(600, 700);

        string s = "Madam";
        Console.WriteLine($"Is '{s}' a palindrome? {s.IsPalindrome()}");
    }
}
