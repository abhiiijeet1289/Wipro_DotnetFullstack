// using System;

// class StudentFee
// {
//     // Delegate to calculate invoice (tuition + transport)
//     public delegate int Admin(int tuitionFees, int transportFees);

//     // Delegate to print invoice result
//     public delegate void PrintData(int invoice);

//     public static void Main(string[] args)
//     {
//         // Assign methods to delegates
//         Admin calculateInvoice = AddNumbers;
//         PrintData printInvoice = PrintResult;

//         // Call methods via delegate
//         int totalInvoice = calculateInvoice(10000, 2000);
//         printInvoice(totalInvoice);
//     }

//     // Method to calculate total invoice
//     public static int AddNumbers(int tuitionFees, int transportFees)
//     {
//         return tuitionFees + transportFees;
//     }

//     // Method to print the final invoice
//     public static void PrintResult(int invoice)
//     {
//         Console.WriteLine("Total Invoice Amount: ₹" + invoice);
//     }
// }


using System;

class StudentFee
{
    // Step 1: Define delegates
    public delegate int Admin(int tuition, int transport);
    public delegate void PrintData(int total);

    // Step 2: Main method
    static void Main()
    {
        // Step 3: Assign methods to delegates
        Admin admin = CalculateInvoice;
        PrintData print = ShowInvoice;

        // Step 4: Call delegates
        int totalAmount = admin(8000, 2000); // Tuition = 8000, Transport = 2000
        print(totalAmount);
    }

    // Step 5: Method to calculate invoice
    public static int CalculateInvoice(int tuition, int transport)
    {
        return tuition + transport;
    }

    // Step 6: Method to print invoice
    public static void ShowInvoice(int amount)
    {
        Console.WriteLine("Total Invoice: ₹" + amount);
    }
}

