using System;

public class DeliveryApp
{
    public static void Main()
    {
        DeliveryPlatform partner = new ZomatoPartner(); // creating object
        partner.PartnerName = "Zomato";

        partner.TrackOrder();
        partner.DeliveryOrder();

        IpaymentGateway payment = (IpaymentGateway)partner;
        payment.ProcessPayment();
    }
}
