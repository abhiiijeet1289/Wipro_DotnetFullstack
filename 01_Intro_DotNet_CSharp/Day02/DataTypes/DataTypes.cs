using System;

public class DataTypes
{
    public static void Main()
    {
        Console.Write("Datatypes:- ");
        Console.Write("Enter an int value:- ");
        int myInt = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a byte value:- ");
        byte myByte = Convert.ToByte(Console.ReadLine());

        Console.Write("Enter a short value:- ");
        short myShort = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter a long value:- ");
        long myLong = Convert.ToInt64(Console.ReadLine());

        Console.Write("Enter a float value:- ");
        float myFloat = float.Parse(Console.ReadLine());

        Console.Write("Enter a double value:- ");
        double myDouble = double.Parse(Console.ReadLine());

        Console.Write("Enter a decimal Value:- ");
        decimal myDecimal = decimal.Parse(Console.ReadLine());

        Console.Write("Enter a character:- ");
        char myChar = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter a boolean:- ");
        bool myBoolean = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Enter a string:- ");
        String myString = Console.ReadLine();

        Console.WriteLine("Int:- " + myInt);
        Console.WriteLine("Byte:- " + myByte);
        Console.WriteLine("Short:- " + myShort);
        Console.WriteLine("Long:- " + myLong);
        Console.WriteLine("Float:- " + myFloat);
        Console.WriteLine("Double:- " + myDouble);
        Console.WriteLine("Decimal:- " + myDecimal);
        Console.WriteLine("Character:- " + myChar);
        Console.WriteLine("Boolean:- " + myBoolean);
        Console.WriteLine("String:- "+ myString);


    }
}