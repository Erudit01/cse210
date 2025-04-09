using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "New York", "NY", "USA"));
        Customer customer2 = new Customer("Alice Smith", new Address("456 Maple Ave", "Toronto", "ON", "Canada"));
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MOU456", 25.50, 2));
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "HEA789", 75.99, 1));
        order2.AddProduct(new Product("Keyboard", "KEY101", 45.75, 1));
        List<Order> orders = new List<Order> { order1, order2 };
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}\n");
            Console.WriteLine("-----------------------------\n");
        }
    }
}