using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool sumFind = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                long leftSum = 0;
                long rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }
                for (int j = i+1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    sumFind = true;
                }

            }
            if (!sumFind)
            {
                Console.WriteLine("no");
            }

        }
    }
}
