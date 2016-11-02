using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = Triangle(side, height);
                Console.WriteLine("{0:0.00}",area);
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = Square(side);
                Console.WriteLine("{0:0.00}", area);
            }
            else if (figureType == "rectangle")
            {                
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    double area = Rectangle(side, height);
                    Console.WriteLine("{0:0.00}", area);                
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Circle(radius);
                Console.WriteLine("{0:0.00}", area);
            }
        }

        private static double Circle(double radius)
        {
            return Math.PI*radius*radius;
        }

        private static double Rectangle(double side, double height)
        {
            return side * height;
        }

        private static double Square(double side)
        {
            return Math.Pow(side , 2);
        }

        private static double Triangle(double side, double height)
        {
            return (side * height) / 2;
        }
    }
}
