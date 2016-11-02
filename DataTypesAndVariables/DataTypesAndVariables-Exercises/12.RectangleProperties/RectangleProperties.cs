using System; 

namespace _12.RectangleProperties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(Perimeter(width, height));
            Console.WriteLine(Area(width, height));
            Console.WriteLine(Diagonal(width, height));

        }

        public static double Perimeter(double width, double height)
        {
            return (height + width) * 2;
        }
        private static double Diagonal(double width, double height)
        {
            return Math.Sqrt((height * height) + (width * width));
        }

        
        public static double Area(double width, double height)
        {
            return (width * height);
        }
    }
}
