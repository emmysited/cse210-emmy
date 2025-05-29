using System;

class Program
{
    static void Main(string[] args)
    {
         // First order
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("MCOSUTRE EMMANUEL", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Keyboard", "P001", 25.99, 2));
        order1.AddProduct(new Product("Mouse", "P002", 15.50, 1));

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine();

        // Second order
        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("ELLY JONES", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("USB-C Cable", "P003", 10.00, 3));
        order2.AddProduct(new Product("Phone Charger", "P004", 20.00, 1));

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}