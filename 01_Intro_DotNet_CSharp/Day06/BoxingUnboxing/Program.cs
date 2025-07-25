using System;
using System.Collections; // For ArrayList
using System.Collections.Generic; // For List<T>

class NonGenericExample
{
    static void Main()
    {
        // -------------------- Non-Generic Example --------------------
        ArrayList arrayList = new ArrayList();  // ArrayList stores elements as object (non-generic)
        int value = 20;

        arrayList.Add(value); // Boxing happens here (int -> object)

        // Console.WriteLine(arrayList.GetType()); // Prints "System.Collections.ArrayList"

        // Unboxing - we need to cast the object back to int
        int unboxingValue = (int)arrayList[0];
        Console.WriteLine("The value after unboxing: " + unboxingValue);

        // -------------------- Generic Example --------------------
        List<int> intList = new List<int>(); // Generic list, type-safe
        intList.Add(value); // No boxing
        int value2 = intList[0]; // No unboxing
        Console.WriteLine("The value from generic list: " + value2);

        // -------------------- Invalid Unboxing (Runtime Error Example) --------------------
        // Uncommenting below lines will cause runtime error
        /*
        arrayList.Add("hello");
        int wrongCast = (int)arrayList[1]; // InvalidCastException at runtime
        */

        // -------------------- Wrapper Class Info --------------------
        // System.Int32 wraps int
        // System.Double wraps double
        // System.Object is the universal base class for all types in C#
    }
}
