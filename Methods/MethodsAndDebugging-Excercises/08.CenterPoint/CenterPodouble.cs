using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPodouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double distanceToCenturA = DistanceToTwoPoints(x1, y1, 0, 0);
            double distanceToCenturB = DistanceToTwoPoints(x2, y2, 0, 0);
            Console.WriteLine(distanceToCenturA > distanceToCenturB ? $"({x2}, {y2})" : $"({x1}, {y1})");
        }

        static double DistanceToTwoPoints(double x1, double x2, double y1, double y2)
        {
            double distance = Math.Sqrt((Math.Pow((x1 - x2), 2)) - (Math.Pow((y1 - y2), 2)));
            return distance;
        }
    }
}
