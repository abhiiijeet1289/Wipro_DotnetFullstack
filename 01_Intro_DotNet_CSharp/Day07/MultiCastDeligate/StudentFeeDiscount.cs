// create a delegate for a admin who is responsible for calculating the invoice(int tutionfess , int transportfees) and one more delegate which will print the invoice



using System;

class StudentFee
{
    // Delegate definitions
    public delegate void Admin(int tuition, int transport);
    public delegate void PrintData(int tuition, int transport, int total);

    static int totalInvoice = 0;

    static void Main()
    {
        int tuitionFees = 8000;
        int transportFees = 2000;

        // Multicast delegate to calculate total invoice
        Admin admin = CalculateTuition;
        admin += CalculateTransport;
        admin(tuitionFees, transportFees);

        // Multicast delegate to print invoice and deduction
        PrintData print = PrintActualInvoice;
        print += PrintWithDeduction;
        print(tuitionFees, transportFees, totalInvoice);
    }

    // Adds tuition fee to total
    public static void CalculateTuition(int tuition, int transport)
    {
        totalInvoice += tuition;
    }

    // Adds transport fee to total
    public static void CalculateTransport(int tuition, int transport)
    {
        totalInvoice += transport;
    }

    // Prints actual invoice
    public static void PrintActualInvoice(int tuition, int transport, int total)
    {
        Console.WriteLine($" Tution Fee + Transport Fee: ₹{total}");
    }

    // Prints deduction based on user choice
    public static void PrintWithDeduction(int tuition, int transport, int total)
    {
        Console.WriteLine("\n--- Deduction Options ---");
        Console.WriteLine("1. 100% from Tuition Fees");
        Console.WriteLine("2. 80% of Total Fees");
        Console.Write("Enter option (1 or 2): ");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.WriteLine($"Deduction (100% Tuition): ₹{tuition}");
                break;

            case 2:
                int deduction = (int)(total * 0.80);
                Console.WriteLine($"Deduction (80% of Total): ₹{deduction}");
                break;

            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }
}
