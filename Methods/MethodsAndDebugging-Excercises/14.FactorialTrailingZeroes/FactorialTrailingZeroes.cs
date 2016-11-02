using System;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());
            
            string facNumberString = Factoriall(number);
            ulong lastDigit = LastDigitIsZero(Factoriall(number));
            Console.WriteLine(lastDigit);
             /* if (lastDigit <= 1 )
              {
                  Console.WriteLine(number + "! = " + facNumberString + "-> One trailing zero ");
              }

              else
              {
                  Console.WriteLine(facNumberString + "The last digit zero is: " + lastDigit);
              }*/
        }

        private static ulong LastDigitIsZero(string facNumberString)
        {
            ulong lastDigit = 0L;
            int sizeString = (facNumberString.Length - 1);
            for (int i = sizeString ; i >= 0 ; i--)
            {
                if (facNumberString[i] == '0')
                {
                    lastDigit++;
                    
                }
                else
                {
                    break;
                }
            }
            return lastDigit;
        }

        private static string Factoriall(int number)
        {
            BigInteger result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            string resultString = result.ToString();
            return resultString;
           
        }
    }
    
}
