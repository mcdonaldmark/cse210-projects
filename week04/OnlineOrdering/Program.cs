using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Razor Blade", "1", 5.99, 3);
        Product product2 = new Product("Haircut Kit", "2", 20.00, 1);

        // Create some customers
        Address address1 = new Address("1433 W 100 E", "Pleasant View", "UT", "USA");
        Customer customer1 = new Customer("Donald Duck", address1);

        Address address2 = new Address("1500 E. Canada Lane", "Province", "ON", "Canada");
        Customer customer2 = new Customer("Mickey Mouse", address2);

        // Create some orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);

        // Print packing labels, shipping labels, and total prices for the orders
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total price: $" + order1.GetTotalPrice());

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total price: $" + order2.GetTotalPrice());
    }
}