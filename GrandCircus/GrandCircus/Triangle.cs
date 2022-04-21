using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus
{
    public class Triangle
    {
        public double Side1Length { get; set; }
        public double Side2Length { get; set; }
        public double Side3Length { get; set; }

        //Constructor
        public Triangle(double side1, double side2, double side3)
        {
            Side1Length = side1;
            Side2Length = side2;
            Side3Length = side3;
        }

        //Method1
        public double CalculatePerimeter()
        {
            double perimeter;
            perimeter = Side1Length + Side2Length + Side3Length;
            return perimeter;
        }

        //Method2
        public double CalculateArea()
        {
            var s = (Side1Length + Side2Length + Side3Length) / 2;
            double area;
            area = (Math.Sqrt(s * (s - Side1Length) * (s - Side2Length) * (s - Side3Length)));
            return area;
        }

    }

}
