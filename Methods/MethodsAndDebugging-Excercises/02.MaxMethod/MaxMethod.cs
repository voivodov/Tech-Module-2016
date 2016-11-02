using System; 

namespace _02.MaxMethod
{
    class MaxMethod
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(Get(a,b,c));

        }

        public static double Get(double a, double b,double c)
        {
            if ((a > b) && (a > c))
            {
                return a;
            }
            else if ((a < b) && (b > c))
                return b;
            else
                return c;
        }
    }
}
