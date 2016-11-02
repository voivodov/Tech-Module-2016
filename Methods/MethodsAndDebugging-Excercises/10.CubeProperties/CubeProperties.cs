using System;


namespace _10.CubeProperties
{
    class CubeProperties
    {
        static void Main()
        {
           double a = double.Parse(Console.ReadLine());
           string type = Console.ReadLine();
            
            if (type == "face")
            {
                Console.WriteLine("{0:F2}", Face(a));
            }
            else if (type == "space")
            {
                Console.WriteLine("{0:F2}", Space(a));
            }
            else if (type == "volume")
            {
                Console.WriteLine("{0:F2}", Volume(a));
            }
            else if (type == "area")
            {
                Console.WriteLine("{0:F2}", Area(a));
            }
        }

        
        static double Space(double a)
        {
            return Math.Sqrt(3 * (a * a));
        }
        static double Area(double a)
        {

            return 6.0*(a * a);
        }
        static double Volume(double a)
        {
            return Math.Pow(a , 3.0d);
        }
        static double Face(double a)
        {
            return Math.Sqrt(2 * (a * a));
        }
    }
}
