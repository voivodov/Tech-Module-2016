using System; 

namespace _06.PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long inputNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(inputNumber));
        }

        private static bool IsPrime(long inputNumber)
        {
            if (inputNumber == 0 || inputNumber == 1 )
            {
                return false;
            }

            for (long i = 2; i <= Math.Sqrt(inputNumber); i++)
            {
                if (inputNumber % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
           
        }
    }

