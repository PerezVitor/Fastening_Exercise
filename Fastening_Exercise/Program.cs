using System;
using Fastening_Exercise.Entities.Enum;
using Fastening_Exercise.Entities;

namespace Fastening_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();
            Console.Write("Email: ");
            string emailClient = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDateClient = DateTime.Parse(Console.ReadLine());
            Client client1 = new Client(nameClient, emailClient, birthDateClient);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Order newOrder = new Order(DateTime.Now, orderStatus, client1);

            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());

            for(int x = 1; x <= items; x++)
            {
                Console.WriteLine($"Enter #{x} item data:");
                Console.Write("Product name: ");
                string pdtName = Console.ReadLine();
                Console.Write("Product price: ");
                double pdtPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int pdtQnt = int.Parse(Console.ReadLine());

                Product product = new Product(pdtName, pdtPrice);
                OrderItem OrderItem = new OrderItem(pdtQnt, pdtPrice, product);

                newOrder.AddItem(OrderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY");
            Console.WriteLine(newOrder);
            Console.ReadLine();
        }
    }
}
