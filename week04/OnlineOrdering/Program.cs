using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
         // --- Order 1 (USA Customer) ---
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "P101", 25.00, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "P102", 75.00, 1));

        // --- Order 2 (International Customer) ---
        Address address2 = new Address("456 Pyay Road", "Yangon", "Yangon Region", "Myanmar");
        Customer customer2 = new Customer("Aung Aung", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("USB-C Hub", "P201", 15.50, 1));
        order2.AddProduct(new Product("HD Monitor", "P202", 150.00, 1));
        order2.AddProduct(new Product("HDMI Cable", "P203", 8.00, 2));

        // Display Order 1 Details
        Console.WriteLine("========================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine("========================================\n");

        // Display Order 2 Details
        Console.WriteLine("========================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("========================================");
    }
}