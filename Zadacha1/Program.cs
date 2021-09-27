using System;
using System.Text;
using Address1;

namespace Zadacha1

{
    class Program

    {

        static void Main(string[] args)
        {

            Console.InputEncoding =
            Console.OutputEncoding =
            Encoding.Unicode;

            var addr = new Address()
            {
                Index = "88005553535",
                Country = "Ukraine",
                City = "Kyiv",
                Street = "Lobachevska st.",
                House = "23",
                Apartment = "825"
            };


            Console.WriteLine("Address:");
            Console.WriteLine(

                $"{addr.Index}, " +
                $"{addr.Country}, " +
                $"{addr.City}, " +
                $"{addr.Street}, " +
                $"{addr.House}, " +
                $"{addr.Apartment}."
            );


            Console.ReadLine();
        }
    }
}

