// using System;

// class InvoiceSystem
// {
//     // Delegate responsible for calculating invoice
//     public delegate int InvoiceCalculator(int tuitionFees, int transportFees);

//     // Multicast delegate for printing invoice
//     public delegate void PrintInvoice(int invoiceAmount);

//     static void Main(string[] args)
//     {
//         // Assign method to calculate total invoice
//         InvoiceCalculator calculateInvoice = CalculateTotalInvoice;

//         // Calculate total invoice using delegate
//         int totalAmount = calculateInvoice(10000, 2000);

//         // Create multicast delegate to print invoice
//         PrintInvoice print = PrintActualInvoice;       // First print method
//         print += PrintWithBonus;                       // Second print method (bonus view)

//         // Invoke both print methods
//         print(totalAmount);
//     }

//     // Method to calculate total invoice
//     private static int CalculateTotalInvoice(int tuition, int transport)
//     {
//         return tuition + transport;
//     }

//     // First method to print actual invoice
//     private static void PrintActualInvoice(int total)
//     {
//         Console.WriteLine($"Actual Invoice Amount: ₹{total}");
//     }

//     // Second method to print invoice with 10x bonus (for demo purposes)
//     private static void PrintWithBonus(int total)
//     {
//         Console.WriteLine($"Invoice after applying bonus (×10): ₹{total * 10}");
//     }
// }
