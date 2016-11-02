using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int maxCounter = 0;
            int position = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        position = i - counter;
                        maxCounter = counter;
                    }
                }

                else
                {
                    counter = 0;
                }
            }
            for (int i = position + 1; i <= position + maxCounter + 1; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
 }

