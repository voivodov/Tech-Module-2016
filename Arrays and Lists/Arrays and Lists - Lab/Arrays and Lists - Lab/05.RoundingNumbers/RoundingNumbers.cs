using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
             
            double[] readNumber = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] nums = new int [readNumber.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (int)Math.Round(readNumber[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{readNumber[i]} -> {nums[i]}");
            }
             
        }
    }
}
