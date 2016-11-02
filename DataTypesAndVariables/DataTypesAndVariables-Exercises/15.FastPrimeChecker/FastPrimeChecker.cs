using System;

namespace _15.FastPrimeChecker
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
             
            for (int i = 2; i <= inputNumber; i++)
            {
                bool isTrue = true;
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i % k == 0)
                    {
                        isTrue = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isTrue}");
            }

        }
    }
}
