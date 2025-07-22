using System;

public abstract class DeliveryPlatform
{
    public string PartnerName { get; set; }

    // Non-abstract Method
    public void TrackOrder()
    {
        Console.WriteLine("Order is being tracked : " + PartnerName);
    }

    // Abstract method to be implemented by subclasses
    public abstract void DeliveryOrder();
}
