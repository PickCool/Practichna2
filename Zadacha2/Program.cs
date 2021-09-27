using System;
using System.Text;
using Rectangle1;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding =
            Console.OutputEncoding =
            Encoding.Unicode;

            Console.Write("The first side of the Rectangle is ");

            double side1 = double.Parse(Console.ReadLine());

            Console.Write("The second side of the Rectangle is ");

            double side2 = double.Parse(Console.ReadLine());

            var rect = new Rectangle(side1, side2);

            Console.WriteLine($"Square of the Rectangle is {rect.Area}");

            Console.WriteLine($"Perimeter of the Rectangle is {rect.Perimeter}");

            Console.ReadLine();
        }
    }
}
