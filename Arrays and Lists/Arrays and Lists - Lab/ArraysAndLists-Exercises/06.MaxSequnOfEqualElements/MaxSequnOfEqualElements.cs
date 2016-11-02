using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequnOfEqualElements
{
    class MaxSequnOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 1;
            int maxNumber = 0;

            foreach (var num in numbers)
            {
                
                if (numbers[num] == (numbers[num]++))
                {
                    int tempCounter = 1;
                    if (tempCounter > counter)
                    {
                        tempCounter = counter;
                        maxNumber = numbers[num]; 
                    }
                }
            }
            Console.WriteLine(numbers[1]+1);
           
        }
    }
}
