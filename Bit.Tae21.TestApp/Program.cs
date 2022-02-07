using System;

namespace Bit.Tae21.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zeichenketten
            string name = "Tom";

            // Zahlenwerte
            int x = 7;
            string b = "234";
            int c = int.Parse(b); // hier kein ein Fehler geworfen werden, wenn es sich nicht um einen int handelt
            bool isValid1 = int.TryParse(b, out int c1);

            // Gleitkommazahl
            float y = 2;

            // Zeichen
            char t = 'c';

            // double / decimal
            decimal a = new decimal(2.5);
            double b1 = 3.6;

            // Umwandlung von String to double
            string doubleToParseString = "23.4";
            bool isValid2 = double.TryParse(doubleToParseString, out double parsedDoubleValue);

            // Umwandlung von String to decimal
            string decimalToParse = "24";
            bool isValid5 = decimal.TryParse(decimalToParse, out decimal parsedDecimalValue);

            // Ja / Nein Werte
            bool abc = false;

            // Umwandlung von String to bool
            string boolToParseString = "true";
            bool isValid3 = bool.TryParse(boolToParseString, out bool parsedBoolValue);

            // Datum & Zeit
            DateTime date = DateTime.Now; // aktuelles Datum
            TimeSpan time = new TimeSpan(15, 30, 25);
            string dateToParse = DateTime.Now.ToString();
            bool isValid4 = DateTime.TryParse(dateToParse, out DateTime parsedDateTimeValue);


            Console.WriteLine("Hello World!");
        }
    }
}
