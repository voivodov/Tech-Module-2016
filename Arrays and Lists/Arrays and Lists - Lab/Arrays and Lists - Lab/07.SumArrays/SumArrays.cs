using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int lenArr1 = arr1.Length;
            int lenArr2 = arr2.Length;

            if (lenArr1>=lenArr2)
            {
                for (int i = 0, j = 0; i < lenArr1; i++ , j++)
                {
                    if (j==lenArr2)
                    {
                        j = 0;
                    }
                    Console.Write(arr1[i] + arr2[j] + " ");
                }
            }
            else if (lenArr1 < lenArr2)
            {
                for (int i = 0, j = 0; i < lenArr2; i++, j++)
                {
                    if (j == lenArr1)
                    {
                        j = 0;
                    }
                    Console.Write(arr2[i] + arr1[j] + " ");
                }
            }
        }
    }
}
