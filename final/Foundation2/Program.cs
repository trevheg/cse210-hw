using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new Customer("Prof. Audie Mosciski Jr.", new Address("32153 Murray Shores Suite 667", "North Torreyton", "NC", "00577", "USA" )));
        order1.addProduct("HTML, CSS, & JavaScript All-in-One For Dummies", 1394164684, 39.99, 1);
        order1.addProduct("New Capenna Booster Pack", 518647354, 4.99, 14);
        order1.addProduct("Oreos", 798537567, 5.95, 2);


        Order order2 = new Order(new Customer("Jadessa Ovaska", new Address("Aliisahaka 850", "Virkkunenkoski", "Etelä-Karjala", "10129", "Finland" )));
        order2.addProduct("How to Win Friends and Influence People", 318473876, 12.95, 1);
        order2.addProduct("I'm with stupid shirt", 831876637, 24.98, 3);
        order2.addProduct("#2 Dad mug", 678176843, 11.99, 2);
        Console.Clear();
        System.Console.WriteLine("Order 1:");
        System.Console.WriteLine(order1.GetShippingLabel());
        System.Console.WriteLine(order1.GetPackingSlip());
        System.Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
        System.Console.WriteLine("");
        System.Console.WriteLine("");
        System.Console.WriteLine("Order 2:");
        System.Console.WriteLine(order2.GetShippingLabel());
        System.Console.WriteLine(order2.GetPackingSlip());
        System.Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }

}

