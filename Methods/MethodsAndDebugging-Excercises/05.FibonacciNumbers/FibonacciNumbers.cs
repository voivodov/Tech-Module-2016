using System; 

namespace _05.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            long inputNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(Fibonaci(inputNumber)); 
        }

        static long Fibonaci(long inputNumber)
        {
            long fib0 = 1;
            long fib1 = 1;
            long fibCurrent = 1;
            for (int i = 1; i < inputNumber; i++)
            {
                fib0 = fib1;
                fib1 = fibCurrent;
                fibCurrent = fib0 + fib1;
            }
            return fibCurrent;
        }
     }
}
