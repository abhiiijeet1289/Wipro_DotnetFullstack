using System;
using System.IO;

class ExceptionExample
{
    static void Main()
    {
        string fpath = "datafile.txt";  // File path used for file-related exceptions

        try
        {
            // --- 1. DivideByZeroException ---
            // int a = 10;
            // int b = 0;
            // int result = a / b;
            // Console.WriteLine("The result is: " + result);

            // --- 2. IndexOutOfRangeException ---
            // int[] arr = { 45, 67, 78 };
            // Console.WriteLine("The value is: " + arr[5]);

            // --- 3. FileNotFoundException / IOException ---
            // using (StreamReader reader = new StreamReader(fpath))
            // {
            //     string content = reader.ReadToEnd();
            //     Console.WriteLine(content);
            // }

            // --- 4. FormatException ---
            int a = int.Parse("abc");  // Invalid integer string
        }

        // Specific catch blocks (uncomment as needed)

        // catch (FileNotFoundException ex)
        // {
        //     Console.WriteLine("File not found: " + ex.FileName);
        // }

        // catch (UnauthorizedAccessException ex)
        // {
        //     Console.WriteLine("Access denied: " + ex.Message);
        // }

        // catch (IOException ex)
        // {
        //     Console.WriteLine("I/O error: " + ex.Message);
        // }

        catch (FormatException ex)
        {
            Console.WriteLine("Format error: " + ex.Message);
        }

        // catch (DivideByZeroException ex)
        // {
        //     Console.WriteLine("Cannot divide by zero.");
        // }

        // catch (IndexOutOfRangeException ex)
        // {
        //     Console.WriteLine("Array index out of range.");
        // }

        // catch (Exception ex)
        // {
        //     Console.WriteLine("General error: " + ex.Message);
        // }

        // finally block (always runs)
        // finally
        // {
        //     Console.WriteLine("Execution completed. Exception handled or not.");
        // }
    }
}
