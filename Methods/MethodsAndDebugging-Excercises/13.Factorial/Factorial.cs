using System;
using System.Numerics; 

namespace _13.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Factoriall(number);
        }

        private static void Factoriall(int number)
        {
            BigInteger result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
