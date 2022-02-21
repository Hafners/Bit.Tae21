using Bit.Tae21.TestApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bit.Tae21.TestApp
{
    class Lieferant
    {
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = ReadCustomers();
            DisplayUserInput(customers);
        }

        private static List<Customer> ReadCustomers()
        {
            List<Customer> customers = new List<Customer>();

            string exitCommand = string.Empty;
            do
            {
                Customer customer = new Customer();

                Console.WriteLine("Bitte geben Sie den Namen ein");
                customer.Name = Console.ReadLine();

                Console.WriteLine("Bitte geben Sie das Alter ein");
                string userInput = Console.ReadLine();
                bool isValid = int.TryParse(userInput, out int parsedInput);
                if (isValid)
                {
                    customer.Age = parsedInput;
                }

                List<ContactPerson> contactPersons = ReadContactPersons();
                customer.ContactPersons.AddRange(contactPersons);

                customers.Add(customer);

                Console.WriteLine("Wollen Sie die Eingabe beenden?");
                exitCommand = Console.ReadLine();

            } while (exitCommand != "Exit");

            return customers;
        }

        private static void DisplayUserInput(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Name: {customer.Name}");
                Console.WriteLine($"Alter: {customer.Age}");
                Console.WriteLine("Kontaktpersonen");
                
                foreach(ContactPerson contactPerson in customer.ContactPersons)
                {
                    Console.WriteLine($"\tName: {contactPerson.FirstName} {contactPerson.LastName}");
                    Console.WriteLine("\tBestellungen:");

                    foreach (Order order in contactPerson.Orders)
                    {
                        Console.WriteLine($"\t\tBestellsumme: {order.SummaryAmount}");
                        Console.WriteLine($"\t\tBestelldatum: {order.CreatedAt.ToShortDateString()}");
                        
                        Console.WriteLine("\t\tPositionen:");
                        foreach (OrderPosition position in order.Positions)
                        {
                            Console.WriteLine($"\t\t\tArtikelnummer: {position.ArticleNumber}");
                            Console.WriteLine($"\t\t\tBetrag: {position.Amount}");
                        }
                    }
                }
            }
        }

        private static List<ContactPerson> ReadContactPersons()
        {
            List<ContactPerson> contactPersons = new List<ContactPerson>();

            bool createContactPerson = true;
            do
            {
                Console.WriteLine("Wollen Sie eine Kontaktperson anlegen? (y/n)");
                string userInput = Console.ReadLine();

                createContactPerson = string.Equals("y", userInput, StringComparison.OrdinalIgnoreCase);
                if (createContactPerson)
                {
                    ContactPerson contactPerson = new ContactPerson();

                    Console.WriteLine("Bitte geben Sie den Vornamen ein:");
                    contactPerson.FirstName = Console.ReadLine();

                    Console.WriteLine("Bitte geben Sie den Nachnamen ein:");
                    contactPerson.FirstName = Console.ReadLine();

                    List<Order> orders = ReadOrders();
                    contactPerson.Orders.AddRange(orders);

                    contactPersons.Add(contactPerson);
                }
            } while (createContactPerson == true);

            return contactPersons;
        }

        private static List<Order> ReadOrders()
        {
            List<Order> orders = new List<Order>();

            bool createOrder = true;
            do
            {
                Console.WriteLine("Wollen Sie eine Bestellung anlegen? (y/n)");
                string userInput = Console.ReadLine();

                createOrder = string.Equals("y", userInput, StringComparison.OrdinalIgnoreCase);
                if (createOrder)
                {
                    Order order = new Order();

                    List<OrderPosition> orderPositions = ReadOrderPositions();
                    order.Positions.AddRange(orderPositions);

                    order.CreatedAt = DateTime.Now;
                    order.SummaryAmount = order.Positions.Sum(x => x.Amount);

                    orders.Add(order);
                }
            } while (createOrder == true);

            return orders;
        }

        private static List<OrderPosition> ReadOrderPositions()
        {
            List<OrderPosition> orderPositions = new List<OrderPosition>();

            bool createOrderPosition = true;
            do
            {
                Console.WriteLine("Wollen Sie eine Position anlegen? (y/n)");
                string userInput = Console.ReadLine();

                createOrderPosition = string.Equals("y", userInput, StringComparison.OrdinalIgnoreCase);
                if (createOrderPosition)
                {
                    OrderPosition orderPosition = new OrderPosition();

                    Console.WriteLine("Bitte geben Sie die Artikelnummer ein:");
                    string articleNumber = Console.ReadLine();
                    bool isValidArticleNumber = int.TryParse(articleNumber, out int parsedArticleNumber);

                    orderPosition.ArticleNumber = isValidArticleNumber ? parsedArticleNumber : 0;

                    Console.WriteLine("Bitte geben Sie den Betrag ein:");
                    string amount = Console.ReadLine();
                    bool isValidAmount = decimal.TryParse(amount, out decimal parsedAmount);

                    orderPosition.Amount = isValidAmount ? parsedAmount : 0;

                    orderPositions.Add(orderPosition);
                }
            } while (createOrderPosition == true);

            return orderPositions;
        }
    }
}
