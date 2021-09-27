using System;

namespace Zadacha8
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

                var invoice = new Invoice(account: 150567, customer: "Jorno Jovano", provider: "Infinite Power", article: "88005553535", quantity: 1);

                Console.WriteLine($"Price without DNS: {invoice.CalculateCost(false)}");

                Console.WriteLine($"Price with DNS: {invoice.CalculateCost(true)}");

                Console.ReadLine();
            }
        
    }
}
