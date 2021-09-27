using System;
using System.Text;
using Dot1;

namespace Zadacha4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding =
            Console.OutputEncoding =
            Encoding.Unicode;

            Console.Write("Type tops number from 3 to 5: ");
            int DotCount = int.Parse(Console.ReadLine());

            if (DotCount < 3 || DotCount > 5)
            {
                Console.WriteLine("This type of figure is not accepted");
                Console.ReadLine();

                return;
            }

            var points = new Dot[DotCount];

            for (int i = 0; i < DotCount; i++)
            {
                Console.WriteLine($"{i + 1} dot:");

                Console.Write("X: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Y: ");
                int y = int.Parse(Console.ReadLine());

                points[i] = new Dot(x, y, "");

                Console.WriteLine();
            }

            Figure figure = null;
            string figureType = null;

            switch (DotCount)
            {
                case 3:

                    figure = new Figure(points[0], points[1], points[2]);
                    figureType = "Triangle";
                    break;

                case 4:

                    figure = new Figure(
                        points[0],
                        points[1],
                        points[2],
                        points[3]
                        );
                    figureType = "Rectangle";
                    break;

                case 5:

                    figure = new Figure(
                        points[0],
                        points[1],
                        points[2],
                        points[3],
                        points[4]
                        );
                    figureType = "Pentagon";

                    break;

                default:

                    Console.WriteLine("This type of figure is not accepted");
                    Console.ReadLine();

                    return;
            }

            Console.WriteLine($"Type of your figure: {figureType}");

            Console.WriteLine($"Perimeter of your figure: {figure.Perimeter}");

            Console.ReadLine();
        }
    }
}
