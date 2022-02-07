using Bit.Tae21.TestApp.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bit.Tae21.TestApp
{
    class U_Schleifen
    {
        public void Uebung()
        {
            string userInput = string.Empty;
            // Schleife - For
            for (int i = 0; i < 10; i++)
            {
                // hier kann etwas gemacht werden
            }

            // Schleife - while
            while (userInput == "Tom")
            {
                // hier kann etwas gemacht werden
            }

            // Schleife - do while
            do
            {
                // hier kann etwas gemacht werden
            } while (userInput == "Tom");

            List<string> kundenNamen1 = new List<string>();
            kundenNamen1.Add("Tom");
            kundenNamen1.Add("Kevin");

            // Schleife - foreach
            foreach (string name in kundenNamen1)
            {
                // hier kann etwas gemacht werden
                Console.WriteLine(name);
            }


            // kürzere Schreibweiße
            List<string> kundenNamen2 = new List<string> { "Kevin", "Tom", "Basti" };
            kundenNamen2.ForEach(x => Console.WriteLine(x));
            kundenNamen2.ForEach(Console.WriteLine);




           
        }

        public void Uebung2()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer{ Id = 1, Name = "Stefan", Age = 28 },
                new Customer{ Id = 2, Name = "Basti", Age = 14 },
                new Customer{ Id = 3, Name = "Kevin", Age = 18 },
            };

            string userInput = string.Empty;
            int id = 3;

            do
            {
                Console.WriteLine("Bitte gib einen weiteren Namen ein:");
                userInput = Console.ReadLine();

                id++;
                customers.Add(new Customer { Id = id, Name = userInput, Age = 19 });
            } while (userInput != "123");

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}
