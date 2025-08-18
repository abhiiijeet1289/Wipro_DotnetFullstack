// OldService.cs
using System;

namespace ConsoleApp2
{
    // Sealed class simulating a legacy or locked service class
    public sealed class OldService
    {
        public int x = 300;

        public void Test1()
        {
            Console.WriteLine("Test 1 method created.");
        }

        public void Test2()
        {
            Console.WriteLine("Test 2 method created.");
        }
    }
}
