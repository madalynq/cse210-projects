using System;

class Program
{
    static void Main()
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address address1 = new Address("237 Pinecone Lane", "Austin", "TX", "USA");
        Customer customer1 = new Customer("Elena Carter", address1);

        Address address2 = new Address("68 Birchwood Street", "Calgary", "AB", "Canada");
        Customer customer2 = new Customer("Noah Bennett", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM802", 15.99, 2));
        order1.AddProduct(new Product("USB-C Cable", "UC144", 8.49, 3));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Desk Lamp", "DL712", 24.99, 1));
        order2.AddProduct(new Product("Monitor Stand", "MS309", 39.95, 1));

        DisplayOrder(order1);
        Console.WriteLine();
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}");
    }
}