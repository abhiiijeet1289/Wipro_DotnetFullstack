using System;

class Program
{
    static void Main()
    {
        // Step 1: Get number of coupons
        Console.Write("Enter number of coupons: ");
        int n = int.Parse(Console.ReadLine());

        // Step 2: Create array to store coupon values
        int[] coupons = new int[n];

        // Variables for calculations
        int totalValue = 0;
        int highestValue = 0;
        int highestPosition = 0;

        int small = 0;
        int medium = 0;
        int large = 0;

        // Step 3: Get coupon values one by one
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter value for coupon #{i + 1}: ");
            coupons[i] = int.Parse(Console.ReadLine());

            totalValue += coupons[i];

            // Check for highest value
            if (coupons[i] > highestValue)
            {
                highestValue = coupons[i];
                highestPosition = i + 1; // 1-based index
            }

            // Category check
            if (coupons[i] <= 50)
            {
                small++;
            }
            else if (coupons[i] <= 100)
            {
                medium++;
            }
            else
            {
                large++;
            }
        }

        // Step 4: Print the summary
        Console.WriteLine("\n----- Daily Coupon Summary -----");
        Console.WriteLine("Total coupons redeemed  : " + n);
        Console.WriteLine("Total value collected   : " + totalValue);
        Console.WriteLine("Highest coupon redeemed : " + highestValue + " (coupon #" + highestPosition + ")");

        Console.WriteLine("\nCategory breakdown");
        Console.WriteLine("Small  (<=50)   : " + small);
        Console.WriteLine("Medium (51-100) : " + medium);
        Console.WriteLine("Large  (>100)   : " + large);
    }
}
