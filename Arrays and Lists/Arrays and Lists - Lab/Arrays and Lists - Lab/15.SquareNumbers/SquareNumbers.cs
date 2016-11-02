using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List <long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List <long> sqrtNums = new List<long>() ;

            for (int i = 0; i < nums.Count; i++)
            {
                if (Math.Sqrt(nums[i]) == (int)Math.Sqrt(nums[i]))
                {
                    sqrtNums.Add(nums[i]);
                }
            }

            sqrtNums.Sort((a,b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", sqrtNums));
        }
    }
}
