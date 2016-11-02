using System;
using System.Numerics;

namespace _7.MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(firstNumber * secondNumber);
        }
    }
}
