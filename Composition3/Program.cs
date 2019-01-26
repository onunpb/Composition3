using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composition3.Entities;
using Composition3.Enums;
using System.Globalization;


namespace Composition3
{
    class Program
    {
        static void Main(string[] args)
        {
              

            Console.WriteLine("Enter Client Data:");
            //Name
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            //Email
            Console.Write("Email: ");
            string email = Console.ReadLine();
            //BirthDate
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
          
            Console.WriteLine("Enter Order Data:");
            //Status
            Console.Write("Status: ");
            string _status = Console.ReadLine();
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), _status);

            //Objeto Client
            Client client = new Client(clientName, email, birthDate);

            //Objeto Order
            Order order = new Order(DateTime.Now, status, client);

            //Items Number
            Console.Write("How many items to this order? ");
            int nrItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nrItems; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product Name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product Price: ");
                double prodPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                //Objeto Product
                Product product = new Product(prodName, prodPrice);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                //Objeto OrderItem
                OrderItem orderItem = new OrderItem(quantity, prodPrice, product);

                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
            Console.ReadLine();


        }
    }
}
