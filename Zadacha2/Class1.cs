using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle1
{
    public class Rectangle
    {
        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

        private double side1;

        private double side2;

        public Rectangle( double side1, double side2)
        {
            this.side1 = side1;

            this.side2 = side2;
        }

        private double AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return (side1 + side2) * 2d;
        }
    }
}
