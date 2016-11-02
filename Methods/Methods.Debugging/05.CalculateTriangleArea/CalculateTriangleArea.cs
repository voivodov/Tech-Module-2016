using System; 

namespace _05.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(GetArea(widht, height));
            
        }

        static double GetArea(double widht,  double height)
        {
            return widht * height / 2;
        }
    }
}
