using System;

class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product("Product 1", "PID1", 10.99m, 2);
        Product product2 = new Product("Product 2", "PID2", 5.99m, 3);
        Product product3 = new Product("Product 3", "PID3", 7.99m, 1);

        // Create customers
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Display order information
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("Total Cost: " + order1.TotalCost());
        Console.WriteLine();
        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine("Total Cost: " + order2.TotalCost());
    }
}
