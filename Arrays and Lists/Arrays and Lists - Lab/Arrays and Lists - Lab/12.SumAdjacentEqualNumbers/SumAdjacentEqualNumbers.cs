using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i-1] == nums[i])
                {
                    nums[i - 1] += nums[i];
                    nums.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
