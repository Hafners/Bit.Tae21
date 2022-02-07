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
    }
}
