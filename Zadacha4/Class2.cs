using System;
using System.Collections.Generic;
using System.Text;
using Dot1;

namespace Zadacha4
{
    public class Figure
    {
        private Dot[] points;

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

        public Figure(Dot p1, Dot p2, Dot p3)
        {
            points = new Dot[] { p1, p2, p3 };
        }

        public Figure(Dot p1, Dot p2, Dot p3, Dot p4)
        {
            points = new Dot[] { p1, p2, p3, p4 };
        }

        public Figure(Dot p1, Dot p2, Dot p3, Dot p4, Dot p5)
        {
            points = new Dot[] { p1, p2, p3, p4, p5 };
        }

        private static double LengthSide(Dot A, Dot B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2d) + Math.Pow(B.Y - A.Y, 2d));
        }


        private double PerimeterCalculator()
        {
            double result = 0d;

            for (int i = 0; i < points.Length - 1; i++)
                result += LengthSide(points[i], points[i + 1]);

            result += LengthSide(points[0], points[points.Length - 1]);

            return result;
        }
    }
}
