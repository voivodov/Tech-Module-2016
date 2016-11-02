using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {

            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

           
            int smallerArrayLenght = Math.Min(firstArray.Length, secondArray.Length);

            int leftCounter = ChechArrayes(firstArray, secondArray, smallerArrayLenght);
            

            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            int rightCounter = ChechArrayes(firstArray, secondArray, smallerArrayLenght); 
            Console.WriteLine(Math.Max(leftCounter, rightCounter));

        }

        private static int ChechArrayes(string[] firstArray, string[] secondArray,  int smallerArrayLenght)
        {
            int counter = 0;
            for (int i = 0; i < smallerArrayLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter++;
                }
                else
                    break;
            }

            return counter;
        }
    }
}
