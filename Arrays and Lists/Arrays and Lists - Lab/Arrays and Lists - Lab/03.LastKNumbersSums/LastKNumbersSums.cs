using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNumbersSums
{
    class LastKNumbersSums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] arr = new long[n];
            arr[0] = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                long sum = 0;
                int count = k;

                for (int j = i-1; j >= 0; j--)
                {
                    if (count == 0)
                    {
                        break;
                    }
                    sum += arr[j];
                    count--;
                }
                arr[i] = sum;
            }
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
