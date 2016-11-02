using System;

namespace _07.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();
            if (type == "int")
            {
                MaxInt(value1, value2);
            }
            else if (type == "char")
            {
                MaxChar(value1, value2);
            }

            else
            {
                MaxString(value1, value2);
            }

        }
        private static void MaxString(string v1, string v2)
        {
            if (v1[0] > v2[0])
            {
                Console.WriteLine(v1);
            }
            else Console.WriteLine(v2);
        }

        private static void MaxChar(string v1, string v2)
        {
            char val1 = char.Parse(v1);
            char val2 = char.Parse(v2);
            if (val1 > val2)
                Console.WriteLine(val1);
            else Console.WriteLine(val2);
        }
        private static void MaxInt(string value1, string value2)
        {
            int val1 = int.Parse(value1);
            int val2 = int.Parse(value2);
            if (val1 > val2)
                Console.WriteLine(val1);
            else Console.WriteLine(val2);
        }
    }

}
