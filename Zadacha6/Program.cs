using System;

namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            var converter = new Converter(usd: 1d / 26.73d, eur: 1d / 31.33d, rub: 1d / 0.37d);

            Console.WriteLine("1 - USD to UAH");
            Console.WriteLine("2 - EUR to UAH");
            Console.WriteLine("3 - RUB to UAH");
            Console.WriteLine("4 - UAH to USD");
            Console.WriteLine("5 - UAH to EUR");
            Console.WriteLine("6 - UAH to RUB");
            Console.WriteLine();

            Console.Write("You have chosen: ");
            int choice;
            bool choiceParsed = int.TryParse(Console.ReadLine(), out choice);

            if (!choiceParsed)
            {
                Console.WriteLine("Error");
                Console.ReadLine();
                return;
            }

            Console.Write("Count of currency: ");
            double value;
            bool valueParsed = double.TryParse(Console.ReadLine(), out value);

            if (!valueParsed)
            {
                Console.WriteLine("Unacceptable value");
                Console.ReadLine();
                return;
            }

            Console.Write("Result: ");

            switch (choice)
            {

                case 1:
                    Console.WriteLine(converter.ConvertFromUsd(value));
                    break;

                case 2:
                    Console.WriteLine(converter.ConvertFromEur(value));
                    break;

                case 3:
                    Console.WriteLine(converter.ConvertFromRub(value));
                    break;

                case 4:
                    Console.WriteLine(converter.ConvertToUsd(value));
                    break;

                case 5:
                    Console.WriteLine(converter.ConvertToEur(value));
                    break;

                case 6:
                    Console.WriteLine(converter.ConvertToRub(value));
                    break;

                default:
                    Console.WriteLine("-");
                    Console.WriteLine("Unacceptable convertation");
                    break;
            }

            Console.ReadLine();

        }
    }
}
