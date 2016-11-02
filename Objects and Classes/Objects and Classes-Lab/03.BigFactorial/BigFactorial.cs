using System;
using System.Numerics;

namespace _03.BigFactorial
{
    class BigFactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int number = 2; number <= n; number++)
            {
                result *= number;
            }

            Console.WriteLine(result);
        }
    }
}
