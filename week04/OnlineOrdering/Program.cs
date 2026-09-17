using System;

class Program
{
    static void Main(string[] args)
    {
        // -------------------------
        // ORDER 1 - USA CUSTOMER
        // -------------------------

        Address address1 = new Address(
            "125 Main Street",
            "Houston",
            "Texas",
            "USA"
        );

        Customer customer1 = new Customer(
            "Michael Johnson",
            address1
        );

        Order order1 = new Order(customer1);

        order1.AddProduct(
            new Product("Wireless Mouse", "WM101", 25.00, 2)
        );

        order1.AddProduct(
            new Product("USB-C Cable", "UC202", 12.50, 3)
        );

        order1.AddProduct(
            new Product("Laptop Stand", "LS303", 40.00, 1)
        );

        // -------------------------
        // ORDER 2 - INTERNATIONAL
        // -------------------------

        Address address2 = new Address(
            "25 Admiralty Way",
            "Lagos",
            "Lagos",
            "Nigeria"
        );

        Customer customer2 = new Customer(
            "David Williams",
            address2
        );

        Order order2 = new Order(customer2);

        order2.AddProduct(
            new Product("Mechanical Keyboard", "MK404", 65.00, 1)
        );

        order2.AddProduct(
            new Product("Webcam", "WC505", 45.00, 2)
        );

        // Store orders in a list
        List<Order> orders = new List<Order>
        {
            order1,
            order2
        };

        // Display order information
        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine($"========== ORDER {orderNumber} ==========");
            Console.WriteLine();

            Console.WriteLine("PACKING LABEL:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("SHIPPING LABEL:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();

            Console.WriteLine(
                $"TOTAL PRICE: ${order.CalculateTotalPrice():F2}"
            );

            Console.WriteLine();
            orderNumber++;
        }
    }
}