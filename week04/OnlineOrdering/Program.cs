using System;

class Program
{
    static void Main(string[] args)
    {
        // ---------- ORDER 1 (USA) ----------
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer cust1 = new Customer("John Doe", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P200", 20, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");
        Console.WriteLine("\n-----------------------------\n");

        // ---------- ORDER 2 (NON-USA) ----------
        Address addr2 = new Address("45 Aba Road", "Port Harcourt", "Rivers", "Nigeria");
        Customer cust2 = new Customer("Darlington Okorie", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Phone", "P300", 500, 1));
        order2.AddProduct(new Product("Headphones", "P400", 50, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}