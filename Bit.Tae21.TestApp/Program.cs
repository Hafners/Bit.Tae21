using Bit.Tae21.TestApp.Objects;
using System;
using System.Collections.Generic;

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
            Customer customer1 = new Customer()
            {
                Id = 1,
                 Age = 28,
                  Name = "Heinz",
                 
            };

            customer1.ContactPersons.Add(
                new ContactPerson { Id = 2, FirstName = "Melanie", LastName = "Ober" });







            List<Lieferant> lieferanten = new List<Lieferant>();

            string exitCommand = string.Empty;
            do
            {
                Lieferant lieferant = new Lieferant();

                Console.WriteLine("Bitte geben Sie das Alter ein");
                string userInput = Console.ReadLine();
                bool isValid = int.TryParse(userInput, out int parsedInput);
                if (isValid)
                {

                lieferant.Age = parsedInput;
                }

                Console.WriteLine("Wollen Sie die Eingabe beenden?");
                exitCommand = Console.ReadLine();

                lieferanten.Add(lieferant);

            } while (exitCommand != "Exit");
            
            foreach(Lieferant lieferant in lieferanten)
            {
                Console.WriteLine($"Alter: {lieferant.Age}");
            }

           






            
            
            
             








            
        }
    }
}
