using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TrippleSum
{
    class TrippleSum
    {
        static void Main(string[] args)
        {
            string[] arrayNumbers = Console.ReadLine().Split();
            long[] array = new long[arrayNumbers.Length];
            bool isTrue = false;
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                array[i] = int.Parse(arrayNumbers[i]);
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                long furstNumber = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    long secondNum = array[j];
                    long sum = furstNumber + secondNum;
                    for (int k = 0; k < array.Length; k++)
                    {
                        if (array[k] == sum)
                        {
                            Console.WriteLine($"{furstNumber} + {secondNum} == {sum}");
                            isTrue = true;

                        }
                    }
                }

            }
            if (!isTrue)
            {
                Console.WriteLine("No");
            }
        }
    }
}
