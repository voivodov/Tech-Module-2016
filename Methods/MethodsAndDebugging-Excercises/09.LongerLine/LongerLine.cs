using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double furstLine = DistanceToTwoPoints(x1, y1, x2, y2);
            double secondLine = DistanceToTwoPoints(x3, y3, x4, y4);

            double distanceToCenturPointA = DistanceToTwoPoints(x1, y1, 0, 0);
            double distanceToCenturPointB = DistanceToTwoPoints(x2, y2, 0, 0);
            double distanceToCenturPointC = DistanceToTwoPoints(x3, y3, 0, 0);
            double distanceToCenturPointD = DistanceToTwoPoints(x4, y4, 0, 0); 
            if (furstLine > secondLine)
            {
                if (distanceToCenturPointA >= distanceToCenturPointB)
                {
                    if (distanceToCenturPointA == distanceToCenturPointB)
                        Console.WriteLine($"({x1}, {y1})");

                       Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (distanceToCenturPointC <= distanceToCenturPointD)
                {
                    if (distanceToCenturPointC == distanceToCenturPointD)
                        Console.WriteLine($"({x3}, {y3})");

                        Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                    
                }
            }
            //Console.WriteLine(furstLine > secondLine ? $"({x1}, {y1})({x2}, {y2})" : $"({x3}, {y3})({x4}, {y4})");
            }

            static double DistanceToTwoPoints(double x1, double x2, double y1, double y2)
            {
            double distance = Math.Sqrt((Math.Pow((x1 - x2), 2)) - (Math.Pow((y1 - y2), 2)));
            return distance;
        }
      }
    }

